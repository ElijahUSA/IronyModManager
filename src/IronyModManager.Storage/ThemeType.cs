﻿// ***********************************************************************
// Assembly         : IronyModManager.Storage
// Author           : Mario
// Created          : 02-07-2020
//
// Last Modified By : Mario
// Last Modified On : 03-01-2020
// ***********************************************************************
// <copyright file="ThemeType.cs" company="Mario">
//     Mario
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using IronyModManager.Storage.Common;

namespace IronyModManager.Storage
{
    /// <summary>
    /// Class ThemeType.
    /// Implements the <see cref="IronyModManager.Storage.Common.IThemeType" />
    /// </summary>
    /// <seealso cref="IronyModManager.Storage.Common.IThemeType" />
    public class ThemeType : IThemeType
    {
        #region Properties

        /// <summary>
        /// Gets or sets the brushes.
        /// </summary>
        /// <value>The brushes.</value>
        public virtual IDictionary<string, string> Brushes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
        public virtual bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the styles.
        /// </summary>
        /// <value>The styles.</value>
        public virtual IEnumerable<string> Styles { get; set; }

        #endregion Properties
    }
}
