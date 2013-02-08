#region License

/*
 * Copyright 2002-2009 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF Any KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

#region

using System;
using Spring.Integration.Endpoint;
using Spring.Integration.Scheduling;

#endregion

namespace Spring.Integration.Tests.Endpoint
{
    /// <author>Jonas Partner</author>
    /// <author>Andreas Doehring (.NET)</author>
    public class PollingEndpointStub : AbstractPollingEndpoint
    {
        public PollingEndpointStub()
        {
            Trigger = new IntervalTrigger(TimeSpan.FromMilliseconds(500));
        }

        protected override bool DoPoll()
        {
            throw new SystemException("intentional test failure");
        }
    }
}