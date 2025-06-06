﻿/*
 * MinIO .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2017-2020 MinIO, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Minio.DataModel.Args;

namespace Minio.Examples.Cases;

internal static class GetBucketPolicy
{
    // Get bucket policy 
    public static async Task Run(IMinioClient minio,
        string bucketName = "my-bucket-name")
    {
        try
        {
            var args = new GetPolicyArgs()
                .WithBucket(bucketName);
            Console.WriteLine("Running example for API: GetPolicyAsync");
            var policyJson = await minio.GetPolicyAsync(args).ConfigureAwait(false);
            Console.WriteLine($"Current Policy is {policyJson} for bucket {bucketName}");
            Console.WriteLine();
        }
        catch (Exception e)
        {
            Console.WriteLine($"[Bucket]  Exception: {e}");
        }
    }
}
