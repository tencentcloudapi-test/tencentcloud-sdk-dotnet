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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAsyncSearchTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页的偏移量，默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页单页限制数目，默认值为20，最大值100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <br><li> topicId
        /// 
        /// 按照【日志主题ID】进行过滤。
        /// 类型：String
        /// 
        /// 必选：否
        /// 
        /// <br><li> logsetId
        /// 
        /// 按照【日志集ID】进行过滤，可通过调用DescribeLogsets查询已创建的日志集列表或登录控制台进行查看；也可以调用CreateLogset创建新的日志集。
        /// 
        /// 类型：String
        /// 
        /// 必选：否
        /// 
        /// 每次请求的Filters的上限为10，Filter.Values的上限为5
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

