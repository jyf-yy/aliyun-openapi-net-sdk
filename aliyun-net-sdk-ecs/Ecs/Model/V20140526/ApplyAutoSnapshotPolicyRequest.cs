/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ApplyAutoSnapshotPolicyRequest : RpcAcsRequest<ApplyAutoSnapshotPolicyResponse>
    {
        public ApplyAutoSnapshotPolicyRequest()
            : base("Ecs", "2014-05-26", "ApplyAutoSnapshotPolicy", "ecs", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string autoSnapshotPolicyId;

		private string diskIds;

		private long? ownerId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string AutoSnapshotPolicyId
		{
			get
			{
				return autoSnapshotPolicyId;
			}
			set	
			{
				autoSnapshotPolicyId = value;
				DictionaryUtil.Add(QueryParameters, "autoSnapshotPolicyId", value);
			}
		}

		public string DiskIds
		{
			get
			{
				return diskIds;
			}
			set	
			{
				diskIds = value;
				DictionaryUtil.Add(QueryParameters, "diskIds", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

        public override ApplyAutoSnapshotPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApplyAutoSnapshotPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
