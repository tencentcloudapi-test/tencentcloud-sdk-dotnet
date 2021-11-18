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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulEffectHostList : AbstractModel
    {
        
        /// <summary>
        /// 事件id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }

        /// <summary>
        /// 状态：0: 待处理 1:忽略  3:已修复  5:检测中 6:修复中 7: 回滚中 8:修复失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 最后检测时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 危害等级：1-低危；2-中危；3-高危；4-严重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 主机Quuid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机Uuid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 主机HostIp
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 主机别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// 主机标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 版本信息 0=普通版本 1=专业版 2=旗舰版
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostVersion")]
        public ulong? HostVersion{ get; set; }

        /// <summary>
        /// 是否能自动修复 0 :漏洞不可自动修复，  1：可自动修复， 2：客户端已离线， 3：主机不是旗舰版只能手动修复， 4：机型不允许 ，5：修复中 ，6：已修复， 7：检测中  9:修复失败，10:已忽略 11:漏洞只支持linux不支持Windows 12：漏洞只支持Windows不支持linux，13:修复失败但此时主机已离线，14:修复失败但此时主机不是旗舰版， 15:已手动修复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSupportAutoFix")]
        public ulong? IsSupportAutoFix{ get; set; }

        /// <summary>
        /// 失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixStatusMsg")]
        public string FixStatusMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "HostVersion", this.HostVersion);
            this.SetParamSimple(map, prefix + "IsSupportAutoFix", this.IsSupportAutoFix);
            this.SetParamSimple(map, prefix + "FixStatusMsg", this.FixStatusMsg);
        }
    }
}

