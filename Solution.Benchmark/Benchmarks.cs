using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;
using Microsoft.Extensions.Logging;
using Solution.Data.Dto;
using Solution.Domain;

namespace Solution.Benchmark;

[MemoryDiagnoser(false)]
//[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
public class Benchmarks
{
    private readonly ProductComplexDto _productDto;
    private readonly UserDto _userDto;
    private readonly List<OrderDto> _orderDtos;
    private readonly IMapper _autoMapper;
    private readonly MapperlyMapper _mapperlyMapper;
   
    public Benchmarks()
    {
        //AutoMapper
        var loggerFactory = LoggerFactory.Create(builder => { });
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<UserDto, User>();
            cfg.AddProfile<AutoMapper>();
        }, loggerFactory);
        _autoMapper = mapperConfig.CreateMapper();

        //Mapperly
        _mapperlyMapper = new MapperlyMapper();

        //Mapster
        MapsterMapper.RegisterMappings();


        //TestData
        _productDto = TestDataGenerator.GenerateProduct();
        _userDto = TestDataGenerator.GenerateUser();
        _orderDtos = TestDataGenerator.GenerateOrders(1);
    }

    [Benchmark]
    public User User_AutoMapper()
    {
        return _autoMapper.Map<User>(_userDto);
    }

    [Benchmark]
    public User User_Mapster()
    {
        return _userDto.Adapt<User>();
    }

    [Benchmark]
    public User User_Mapperly()
    {
        return _mapperlyMapper.Map(_userDto);
    }

    [Benchmark]
    public Product Product_AutoMapper()
    {
        return _autoMapper.Map<Product>(_productDto);
    }

    [Benchmark]
    public Product Product_Mapster()
    {
        return _productDto.Adapt<Product>();
    }

    [Benchmark]
    public Product Product_Mapperly()
    {
        return _mapperlyMapper.Map(_productDto);
    }    

    [Benchmark]
    public List<Order> Orders_AutoMapper()
    {
        return _orderDtos.Select(o => _autoMapper.Map<Order>(o)).ToList();
    }

    [Benchmark]
    public List<Order> Orders_Mapster()
    {
        return _orderDtos.Select(o => o.Adapt<Order>()).ToList();
    }

    [Benchmark]
    public List<Order> Orders_Mapperly()
    {
        return _orderDtos.Select(o => _mapperlyMapper.Map(o)).ToList();
    }
}