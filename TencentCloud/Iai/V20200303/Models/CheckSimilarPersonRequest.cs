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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckSimilarPersonRequest : AbstractModel
    {
        
        /// <summary>
        /// 待整理的人员库列表。 
        /// 人员库总人数不可超过200万，人员库个数不可超过10个。
        /// 数组元素取值为创建人员库接口中的GroupId
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// 人员查重整理力度的控制。
        /// 1：力度较高的人员整理，能够消除更多的重复身份，对应稍高的非重复身份误清除率；
        /// 2：力度较低的人员整理，非重复身份的误清除率较低，对应稍低的重复身份消除率。
        /// </summary>
        [JsonProperty("UniquePersonControl")]
        public long? UniquePersonControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "UniquePersonControl", this.UniquePersonControl);
        }
    }
}

