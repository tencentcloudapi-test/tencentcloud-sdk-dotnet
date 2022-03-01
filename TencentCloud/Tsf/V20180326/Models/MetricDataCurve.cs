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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricDataCurve : AbstractModel
    {
        
        /// <summary>
        /// 指标名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 指标计算方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricFunction")]
        public string MetricFunction{ get; set; }

        /// <summary>
        /// 指标数据点集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricDataPoints")]
        public MetricDataPoint[] MetricDataPoints{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "MetricFunction", this.MetricFunction);
            this.SetParamArrayObj(map, prefix + "MetricDataPoints.", this.MetricDataPoints);
        }
    }
}

