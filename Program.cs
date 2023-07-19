using System;
using System.Text.Json;
using AutoMapper;
using controller;
using model;
using RestSharp;
using service;
using utils;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogarController jogo = new JogarController();
        }
    }
}
