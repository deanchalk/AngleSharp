﻿namespace AngleSharp.Infrastructure
{
    using AngleSharp.Media;
    using AngleSharp.Network;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Repesents a service to create / inspect an image.
    /// </summary>
    public interface IImageService : IService
    {
        /// <summary>
        /// Checks if the given type is supported.
        /// </summary>
        /// <param name="mimeType">The type of the image source.</param>
        /// <returns>True if the type is supported, otherwise false.</returns>
        Boolean SupportsType(String mimeType);

        /// <summary>
        /// Tries to create an image inspector.
        /// </summary>
        /// <param name="response">The response that contains the image stream.</param>
        /// <param name="cancel">The token for cancelling the task.</param>
        /// <returns>A task that finishes with infos on the image.</returns>
        Task<IImageInfo> CreateAsync(IResponse response, CancellationToken cancel);
    }
}
