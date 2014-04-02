// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using Microsoft.AspNet.Abstractions;

namespace Microsoft.AspNet.Security.Provider
{
    public abstract class BaseContext
    {
        protected BaseContext(HttpContext context)
        {
            HttpContext = context;
        }

        public HttpContext HttpContext { get; private set; }

        public HttpRequest Request
        {
            get { return HttpContext.Request; }
        }

        public HttpResponse Response
        {
            get { return HttpContext.Response; }
        }
    }
}