﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Did.Ethr.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.Did.Ethr.Store
{
    public class EFIdentityDocumentConfigurationStore : IIdentityDocumentConfigurationStore
    {
        private readonly EthrDbContext _dbContext;

        public EFIdentityDocumentConfigurationStore(EthrDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<NetworkConfiguration> Query() => _dbContext.Networks;

        public void Add(NetworkConfiguration networkConfiguration) => _dbContext.Networks.Add(networkConfiguration);

        public void Remove(NetworkConfiguration networkConfiguration) => _dbContext.Networks.Remove(networkConfiguration);

        public Task<int> SaveChanges(CancellationToken cancellationToken) => _dbContext.SaveChangesAsync(cancellationToken);
    }
}
