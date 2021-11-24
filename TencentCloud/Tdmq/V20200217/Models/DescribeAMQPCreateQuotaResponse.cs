/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAMQPCreateQuotaResponse : AbstractModel
    {
        
        /// <summary>
        /// 租户总共可使用集群数量
        /// </summary>
        [JsonProperty("MaxClusterNum")]
        public ulong? MaxClusterNum{ get; set; }

        /// <summary>
        /// 租户已创建集群数量
        /// </summary>
        [JsonProperty("UsedClusterNum")]
        public ulong? UsedClusterNum{ get; set; }

        /// <summary>
        /// Exchange容量
        /// </summary>
        [JsonProperty("ExchangeCapacity")]
        public ulong? ExchangeCapacity{ get; set; }

        /// <summary>
        /// Queue容量
        /// </summary>
        [JsonProperty("QueueCapacity")]
        public ulong? QueueCapacity{ get; set; }

        /// <summary>
        /// 单Vhost TPS
        /// </summary>
        [JsonProperty("MaxTpsPerVHost")]
        public ulong? MaxTpsPerVHost{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxClusterNum", this.MaxClusterNum);
            this.SetParamSimple(map, prefix + "UsedClusterNum", this.UsedClusterNum);
            this.SetParamSimple(map, prefix + "ExchangeCapacity", this.ExchangeCapacity);
            this.SetParamSimple(map, prefix + "QueueCapacity", this.QueueCapacity);
            this.SetParamSimple(map, prefix + "MaxTpsPerVHost", this.MaxTpsPerVHost);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

