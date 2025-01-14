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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectInfoIdCardData : AbstractModel
    {
        
        /// <summary>
        /// OCR正面照片的base64编码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrFront")]
        public string OcrFront{ get; set; }

        /// <summary>
        /// OCR反面照片的base64编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrBack")]
        public string OcrBack{ get; set; }

        /// <summary>
        /// 旋转裁边后的正面照片base64编码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessedFrontImage")]
        public string ProcessedFrontImage{ get; set; }

        /// <summary>
        /// 旋转裁边后的背面照片base64编码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessedBackImage")]
        public string ProcessedBackImage{ get; set; }

        /// <summary>
        /// 身份证正面人像图base64编码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// 开启身份证防翻拍告警功能后才会返回，返回数组中可能出现的告警码如下：
        /// -9102 身份证复印件告警。
        /// -9103 身份证翻拍告警。
        /// -9106 身份证 PS 告警。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarnInfos")]
        public long?[] WarnInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OcrFront", this.OcrFront);
            this.SetParamSimple(map, prefix + "OcrBack", this.OcrBack);
            this.SetParamSimple(map, prefix + "ProcessedFrontImage", this.ProcessedFrontImage);
            this.SetParamSimple(map, prefix + "ProcessedBackImage", this.ProcessedBackImage);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamArraySimple(map, prefix + "WarnInfos.", this.WarnInfos);
        }
    }
}

