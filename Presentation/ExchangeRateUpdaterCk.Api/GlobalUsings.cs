// Global using directives

global using AutoMapper;
global using ExchangeRateUpdaterCk.Api.Middlewares;
global using ExchangeRateUpdaterCk.Api.Security.Authorization;
global using ExchangeRateUpdaterCk.Data;
global using ExchangeRateUpdaterCk.Data.Repository;
global using ExchangeRateUpdaterCk.Domain.Configurations;
global using ExchangeRateUpdaterCk.Domain.DTOs;
global using ExchangeRateUpdaterCk.Domain.Exceptions;
global using ExchangeRateUpdaterCk.Service.Interfaces;
global using ExchangeRateUpdaterCk.Service.Services;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Newtonsoft.Json;
global using System;
global using System.Collections.Generic;
global using System.ComponentModel.DataAnnotations;
global using System.Diagnostics.CodeAnalysis;
global using System.IdentityModel.Tokens.Jwt;
global using System.Net;
global using System.Net.Http.Headers;
global using System.Security.Claims;
global using System.Text.Encodings.Web;
global using System.Threading.Tasks;
global using ExchangeRateUpdaterCk.Api.DTOs.Requests.Dummy;
global using ExchangeRateUpdaterCk.Api.DTOs.Responses.Dummy;
global using ExchangeRateUpdaterCk.Api.Security.Authentication;
global using Microsoft.OpenApi.Models;
global using IConfigurationProvider = AutoMapper.IConfigurationProvider;