using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;
using Microsoft.Extensions.Logging;
using Solution.Data.Dto;
using Solution.Domain;
using System.Collections.Generic;

namespace Solution.Benchmark;

[MemoryDiagnoser(false)]
//[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
public class Benchmarks
{
    private readonly List<UserDto> _users10;
    private readonly List<UserDto> _users100;
    private readonly List<UserDto> _users1000;
    private readonly List<UserDto> _users10000;

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
        //_productDto = TestDataGenerator.GenerateProduct();
        //_userDto = TestDataGenerator.GenerateUser();
        //_orderDtos = TestDataGenerator.GenerateOrders(1);
        _users10 = TestDataGenerator.GenerateUsers(10);
        _users100 = TestDataGenerator.GenerateUsers(100);
        _users1000 = TestDataGenerator.GenerateUsers(1000);
        _users10000 = TestDataGenerator.GenerateUsers(10000);
    }

    // 10 объектов
    [Benchmark]
    public List<User> Users10_AutoMapper() => _users10.Select(u => _autoMapper.Map<User>(u)).ToList();

    [Benchmark]
    public List<User> Users10_Mapster() => _users10.Select(u => u.Adapt<User>()).ToList();

    [Benchmark]
    public List<User> Users10_Mapperly() => _users10.Select(u => _mapperlyMapper.Map(u)).ToList();

    // 100 объектов
    [Benchmark]
    public List<User> Users100_AutoMapper() => _users100.Select(u => _autoMapper.Map<User>(u)).ToList();

    [Benchmark]
    public List<User> Users100_Mapster() => _users100.Select(u => u.Adapt<User>()).ToList();

    [Benchmark]
    public List<User> Users100_Mapperly() => _users100.Select(u => _mapperlyMapper.Map(u)).ToList();

    // 1000 объектов
    [Benchmark]
    public List<User> Users1000_AutoMapper() => _users1000.Select(u => _autoMapper.Map<User>(u)).ToList();

    [Benchmark]
    public List<User> Users1000_Mapster() => _users1000.Select(u => u.Adapt<User>()).ToList();

    [Benchmark]
    public List<User> Users1000_Mapperly() => _users1000.Select(u => _mapperlyMapper.Map(u)).ToList();

    // 10000 объектов
    [Benchmark]
    public List<User> Users10000_AutoMapper() => _users10000.Select(u => _autoMapper.Map<User>(u)).ToList();

    [Benchmark]
    public List<User> Users10000_Mapster() => _users10000.Select(u => u.Adapt<User>()).ToList();

    [Benchmark]
    public List<User> Users10000_Mapperly() => _users10000.Select(u => _mapperlyMapper.Map(u)).ToList();

    /*
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
    }*/
}