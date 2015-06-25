// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.AspNet.Antiforgery;
using Microsoft.Framework.Internal;

namespace Microsoft.AspNet.Mvc
{
    public class ValidateAntiForgeryTokenAuthorizationFilter : IAsyncAuthorizationFilter
    {
        private readonly IAntiforgery _antiForgery;

        public ValidateAntiForgeryTokenAuthorizationFilter([NotNull] IAntiforgery antiForgery)
        {
            _antiForgery = antiForgery;
        }

        public async Task OnAuthorizationAsync([NotNull] AuthorizationContext context)
        {
            await _antiForgery.ValidateRequestAsync(context.HttpContext);
        }
    }
}