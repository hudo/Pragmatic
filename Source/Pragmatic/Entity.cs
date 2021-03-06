﻿using System;
using Pragmatic.Environment;

namespace Pragmatic
{
    /// <summary>
    /// Base class for all entities in the domain.
    /// </summary>
    [Serializable]
    public abstract class Entity
    {
        /// <summary>
        /// The key of the <see cref="Entity"/>.
        /// If it is <see cref="Guid.Empty"/>, the <see cref="Entity"/> is not yet persisted.
        /// </summary>
        /// <remarks>
        /// Identity Key pattern.
        /// </remarks>
        public Guid Id
        {
            get;
            protected internal set;
        }

        /// <summary>
        /// True if entity is not yet persisted.
        /// </summary>
        public bool IsNewEntity
        {
            get;
            internal set;
        }

        protected Entity()
        {
            Id = PragmaticEnvironment.IdGenerator(GetType());
            IsNewEntity = true;
        }
    }
}
