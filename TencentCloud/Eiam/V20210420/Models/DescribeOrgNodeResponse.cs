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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrgNodeResponse : AbstractModel
    {
        
        /// <summary>
        /// 机构节点展示名称，长度限制：64个字符。 默认与机构名相同。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 机构节点最后修改时间，符合 ISO8601 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifiedDate")]
        public string LastModifiedDate{ get; set; }

        /// <summary>
        /// 机构节点外部ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomizedOrgNodeId")]
        public string CustomizedOrgNodeId{ get; set; }

        /// <summary>
        /// 当前机构节点的父节点ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentOrgNodeId")]
        public string ParentOrgNodeId{ get; set; }

        /// <summary>
        /// 机构节点ID，是机构节点的全局唯一标识。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgNodeId")]
        public string OrgNodeId{ get; set; }

        /// <summary>
        /// 数据来源。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// 机构节点创建时间，符合 ISO8601 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedDate")]
        public string CreatedDate{ get; set; }

        /// <summary>
        /// 当前机构节点下的子节点列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgNodeChildInfo")]
        public OrgNodeChildInfo[] OrgNodeChildInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "LastModifiedDate", this.LastModifiedDate);
            this.SetParamSimple(map, prefix + "CustomizedOrgNodeId", this.CustomizedOrgNodeId);
            this.SetParamSimple(map, prefix + "ParentOrgNodeId", this.ParentOrgNodeId);
            this.SetParamSimple(map, prefix + "OrgNodeId", this.OrgNodeId);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "CreatedDate", this.CreatedDate);
            this.SetParamArrayObj(map, prefix + "OrgNodeChildInfo.", this.OrgNodeChildInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

