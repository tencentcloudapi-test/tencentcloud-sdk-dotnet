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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PoliticalImgReviewTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 画面鉴别涉及令人不适宜的信息的任务开关，可选值：
        /// <li>ON：开启画面鉴别涉及令人不适宜的信息的任务；</li>
        /// <li>OFF：关闭画面鉴别涉及令人不适宜的信息的任务。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 画面鉴别涉及令人不适宜的信息的过滤标签，智能识别结果包含选择的标签则返回结果，如果过滤标签为空，则智能识别结果全部返回，可选值为：
        /// <li>violation_photo：违规图标；</li>
        /// <li>politician：相关人物；</li>
        /// <li>entertainment：娱乐人物；</li>
        /// <li>sport：体育人物；</li>
        /// <li>entrepreneur：商业人物；</li>
        /// <li>scholar：教育学者；</li>
        /// <li>celebrity：知名人物；</li>
        /// <li>military：相关人物。</li>
        /// </summary>
        [JsonProperty("LabelSet")]
        public string[] LabelSet{ get; set; }

        /// <summary>
        /// 判定涉嫌违规的分数阈值，当智能识别达到该分数以上，认为涉嫌违规。取值范围：0~100。
        /// </summary>
        [JsonProperty("BlockConfidence")]
        public long? BlockConfidence{ get; set; }

        /// <summary>
        /// 判定需人工复核是否违规的分数阈值，当智能识别达到该分数以上，认为需人工复核。取值范围：0~100。
        /// </summary>
        [JsonProperty("ReviewConfidence")]
        public long? ReviewConfidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "LabelSet.", this.LabelSet);
            this.SetParamSimple(map, prefix + "BlockConfidence", this.BlockConfidence);
            this.SetParamSimple(map, prefix + "ReviewConfidence", this.ReviewConfidence);
        }
    }
}

