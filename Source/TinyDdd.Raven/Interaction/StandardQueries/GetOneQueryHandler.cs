﻿using System.Linq;
using Raven.Client;
using SwissKnife;
using SwissKnife.Diagnostics.Contracts;
using TinyDdd.Interaction;
using TinyDdd.Interaction.StandardQueries;

namespace TinyDdd.Raven.Interaction.StandardQueries
{
    public class GetOneQueryHandler<TEntity> : BaseQuery, IQueryHandler<GetOneQuery<TEntity>, Option<TEntity>> where TEntity : Entity, IAggregateRoot
    {
        public GetOneQueryHandler(IDocumentSession documentSession) : base(documentSession) { }

        public Option<TEntity> Execute(GetOneQuery<TEntity> query)
        {
            Argument.IsNotNull(query, "query");

            return DocumentSession.Query<TEntity>().FirstOrDefault(query.Criteria);
        }
    }
}