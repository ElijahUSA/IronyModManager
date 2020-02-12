﻿// ***********************************************************************
// Assembly         : IronyModManager.Models
// Author           : Mario
// Created          : 02-12-2020
//
// Last Modified By : Mario
// Last Modified On : 02-12-2020
// ***********************************************************************
// <copyright file="Game.cs" company="Mario">
//     Mario
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System;
using IronyModManager.Localization.Attributes;
using IronyModManager.Models.Common;
using IronyModManager.Shared;

namespace IronyModManager.Models
{
    /// <summary>
    /// Class Game.
    /// Implements the <see cref="IronyModManager.Models.Common.BaseModel" />
    /// Implements the <see cref="IronyModManager.Models.Common.IGame" />
    /// </summary>
    /// <seealso cref="IronyModManager.Models.Common.BaseModel" />
    /// <seealso cref="IronyModManager.Models.Common.IGame" />
    public class Game : BaseModel, IGame
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether this instance is selected.
        /// </summary>
        /// <value><c>true</c> if this instance is selected; otherwise, <c>false</c>.</value>
        public bool IsSelected { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [DynamicLocalization(LocalizationResources.Games.Prefix, nameof(Type))]
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public virtual string Type { get; set; }

        #endregion Properties
    }
}
