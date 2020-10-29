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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaInputInfo : AbstractModel
    {
        
        /// <summary>
        /// 输入来源对象的类型，目前仅支持 COS。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 当 Type 为 COS 时有效，则该项为必填，表示视频处理 COS 对象信息。
        /// </summary>
        [JsonProperty("CosInputInfo")]
        public CosInputInfo CosInputInfo{ get; set; }

        /// <summary>
        /// 当 Type 为 URL 时有效，则该项为必填，表示视频处理 URL 对象信息。
        /// 
        /// 目前尚不支持 URL 输入，该能力将于近期支持。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UrlInputInfo")]
        public UrlInputInfo UrlInputInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CosInputInfo.", this.CosInputInfo);
            this.SetParamObj(map, prefix + "UrlInputInfo.", this.UrlInputInfo);
        }
    }
}

