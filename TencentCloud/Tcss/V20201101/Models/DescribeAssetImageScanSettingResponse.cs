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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetImageScanSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// 开关
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 扫描时刻(完整时间;后端按0时区解析时分秒)
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 扫描间隔
        /// </summary>
        [JsonProperty("ScanPeriod")]
        public ulong? ScanPeriod{ get; set; }

        /// <summary>
        /// 扫描木马
        /// </summary>
        [JsonProperty("ScanVirus")]
        public bool? ScanVirus{ get; set; }

        /// <summary>
        /// 扫描敏感信息
        /// </summary>
        [JsonProperty("ScanRisk")]
        public bool? ScanRisk{ get; set; }

        /// <summary>
        /// 扫描漏洞
        /// </summary>
        [JsonProperty("ScanVul")]
        public bool? ScanVul{ get; set; }

        /// <summary>
        /// 扫描全部镜像
        /// </summary>
        [JsonProperty("All")]
        public bool? All{ get; set; }

        /// <summary>
        /// 自定义扫描镜像
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

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
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "ScanPeriod", this.ScanPeriod);
            this.SetParamSimple(map, prefix + "ScanVirus", this.ScanVirus);
            this.SetParamSimple(map, prefix + "ScanRisk", this.ScanRisk);
            this.SetParamSimple(map, prefix + "ScanVul", this.ScanVul);
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

