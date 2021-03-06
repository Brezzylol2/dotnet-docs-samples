﻿// Copyright 2020 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Talent.V4Beta1;
using System;

namespace GoogleCloudSamples
{
    internal class DeleteJobSample
    {
        // [START job_search_delete_job_beta]
        public static object DeleteJob(string projectId, string tenantId, string jobId)
        {
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            JobName name = new JobName(projectId, tenantId, jobId);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobNameOneof = JobNameOneof.From(name)
            };

            jobServiceClient.DeleteJob(request);

            Console.WriteLine("Deleted Job.");
            return 0;
        }
        // [END job_search_delete_job_beta]
    }
}
