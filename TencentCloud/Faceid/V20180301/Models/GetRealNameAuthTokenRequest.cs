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

    public class GetRealNameAuthTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("IDCard")]
        public string IDCard{ get; set; }

        /// <summary>
        /// 回调地址。实名认证完成后，将会重定向到这个地址通知认证发起方。仅支持http或https协议。
        /// </summary>
        [JsonProperty("CallbackURL")]
        public string CallbackURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IDCard", this.IDCard);
            this.SetParamSimple(map, prefix + "CallbackURL", this.CallbackURL);
        }
    }
}

