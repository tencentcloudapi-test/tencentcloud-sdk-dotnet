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

    public class ExportVirusListRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>FileName - String - 是否必填：否 - 文件名称</li>
        /// <li>FilePath - String - 是否必填：否 - 文件路径</li>
        /// <li>VirusName - String - 是否必填：否 - 病毒名称</li>
        /// <li>ContainerName- String - 是否必填：是 - 容器名称</li>
        /// <li>ContainerId- string - 是否必填：否 - 容器id</li>
        /// <li>ImageName- string - 是否必填：否 - 镜像名称</li>
        /// <li>ImageId- string - 是否必填：否 - 镜像id</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 导出字段
        /// </summary>
        [JsonProperty("ExportField")]
        public string[] ExportField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamArraySimple(map, prefix + "ExportField.", this.ExportField);
        }
    }
}

