﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.IdServer.Domains;

namespace SimpleIdServer.IdServer.Store
{
    public interface ICredentialOfferRepository
    {
        IQueryable<UserCredentialOffer> Query();
        void Add(UserCredentialOffer credentialOffer);
        Task<int> SaveChanges(CancellationToken cancellationToken);
    }

    public class CredentialOfferRepository : ICredentialOfferRepository
    {
        private readonly StoreDbContext _dbContext;

        public CredentialOfferRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<UserCredentialOffer> Query() => _dbContext.CredentialOffers;

        public void Add(UserCredentialOffer credentialOffer) => _dbContext.CredentialOffers.Add(credentialOffer);

        public Task<int> SaveChanges(CancellationToken cancellationToken) => _dbContext.SaveChangesAsync(cancellationToken);
    }
}
