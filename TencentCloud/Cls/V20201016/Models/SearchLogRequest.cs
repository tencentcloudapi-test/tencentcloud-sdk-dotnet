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

    public class SearchLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 要查询的日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 要查询的日志的起始时间，Unix时间戳，单位ms
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// 要查询的日志的结束时间，Unix时间戳，单位ms
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// 查询语句，语句长度最大为12KB
        /// 查询语句由 <a href="https://cloud.tencent.com/document/product/614/47044" target="_blank">[检索条件]</a> | <a href="https://cloud.tencent.com/document/product/614/44061" target="_blank">[SQL语句]</a>构成，无需对日志进行统计分析时，可省略其中的管道符<code>|</code>及SQL语句
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 仅当查询语句(Query)不包含SQL时有效
        /// 表示单次查询返回的原始日志条数，最大值为1000，获取后续日志需使用Context参数
        /// SQL结果条数指定方式参考<a href="https://cloud.tencent.com/document/product/614/58977" target="_blank">SQL LIMIT语法</a>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 仅当查询语句(Query)不包含SQL时有效
        /// 透传上次接口返回的Context值，可获取后续日志，总计最多可获取1万条原始日志。过期时间1小时
        /// SQL获取后续结果参考<a href="https://cloud.tencent.com/document/product/614/58977" target="_blank">SQL LIMIT语法</a>
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 仅当查询语句(Query)不包含SQL时有效。
        /// 原始日志是否按时间排序返回；可选值：asc(升序)、desc(降序)，默认为 desc
        /// SQL结果排序方式参考<a href="https://cloud.tencent.com/document/product/614/58978" target="_blank">SQL ORDER BY 语法</a>
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 为true代表使用新的检索结果返回方式，响应参数AnalysisRecords和Columns有效；为false时代表使用老检索结果返回方式, AnalysisResults和ColNames有效
        /// </summary>
        [JsonProperty("UseNewAnalysis")]
        public bool? UseNewAnalysis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "UseNewAnalysis", this.UseNewAnalysis);
        }
    }
}

