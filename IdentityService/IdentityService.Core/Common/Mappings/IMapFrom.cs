﻿//  <copyright file="IMapFrom.cs" project="Core" solution="IdentityService">
//      Copyright (c) 2020 Nasr Aldin.  All rights reserved.
//      Licensed under the MIT License, See LICENSE in the project root for license information.
//  </copyright>
//  <author>Nasr Aldin</author>
//  <email>nasr2ldin@gmail.com</email>
//  <github>https://github.com/nasraldin/IdentityServer</github>
//  <date>31/05/2020 01:00 AM</date>

using AutoMapper;

namespace IdentityService.Core.Common.Mappings
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
