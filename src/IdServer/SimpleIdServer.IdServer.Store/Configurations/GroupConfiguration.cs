﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleIdServer.IdServer.Domains;

namespace SimpleIdServer.IdServer.Store.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id);
            builder.HasMany(g => g.Children).WithOne(g => g.ParentGroup).HasForeignKey(g => g.ParentGroupId);
            builder.HasMany(g => g.Users).WithMany(g => g.Groups);
            builder.HasMany(g => g.Roles).WithMany(g => g.Groups);
        }
    }
}
