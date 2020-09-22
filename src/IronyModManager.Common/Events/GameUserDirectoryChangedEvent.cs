﻿// ***********************************************************************
// Assembly         : IronyModManager.Common
// Author           : Mario
// Created          : 09-22-2020
//
// Last Modified By : Mario
// Last Modified On : 09-22-2020
// ***********************************************************************
// <copyright file="GameUserDirectoryChangedEvent.cs" company="Mario">
//     Mario
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System;
using IronyModManager.Models.Common;
using IronyModManager.Shared.MessageBus;

namespace IronyModManager.Common.Events
{
    /// <summary>
    /// Class GameUserDirectoryChangedEvent.
    /// Implements the <see cref="IronyModManager.Shared.MessageBus.IMessageBusEvent" />
    /// </summary>
    /// <seealso cref="IronyModManager.Shared.MessageBus.IMessageBusEvent" />
    public class GameUserDirectoryChangedEvent : IMessageBusEvent
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GameUserDirectoryChangedEvent"/> class.
        /// </summary>
        /// <param name="game">The game.</param>
        public GameUserDirectoryChangedEvent(IGame game)
        {
            Game = game;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the game.
        /// </summary>
        /// <value>The game.</value>
        public IGame Game { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is fire and forget.
        /// </summary>
        /// <value><c>true</c> if this instance is fire and forget; otherwise, <c>false</c>.</value>
        public bool IsFireAndForget => true;

        #endregion Properties
    }
}
