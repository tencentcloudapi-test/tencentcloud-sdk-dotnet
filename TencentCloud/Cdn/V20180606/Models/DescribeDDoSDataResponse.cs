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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSDataResponse : AbstractModel
    {
        
        /// <summary>
        /// DDoS统计数据数组
        /// </summary>
        [JsonProperty("Data")]
        public DDoSStatsData[] Data{ get; set; }

        /// <summary>
        /// 时间粒度：
        /// min：1 分钟粒度
        /// 5min：5 分钟粒度
        /// hour：1 小时粒度
        /// day：天粒度
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// DDoS统计攻击带宽峰值数组
        /// </summary>
        [JsonProperty("AttackBandwidthData")]
        public DDoSAttackBandwidthData[] AttackBandwidthData{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "AttackBandwidthData.", this.AttackBandwidthData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

