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

    public class VirusInfo : AbstractModel
    {
        
        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 病毒名称
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 容器名称
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 容器id
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// 容器状态，CS_RUNING:运行， CS_PAUSE:暂停，CS_STOP:停止，
        /// 												       CS_CREATE:已经创建， CS_DESTORY:销毁
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// DEAL_NONE:文件待处理
        /// DEAL_IGNORE:已经忽略
        /// DEAL_ADD_WHITELIST:加白
        /// DEAL_DEL:文件已经删除
        /// DEAL_ISOLATE:已经隔离
        /// DEAL_ISOLATING:隔离中
        /// DEAL_ISOLATE_FAILED:隔离失败
        /// DEAL_RECOVERING:恢复中
        /// DEAL_RECOVER_FAILED: 恢复失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [JsonProperty("HarmDescribe")]
        public string HarmDescribe{ get; set; }

        /// <summary>
        /// 建议方案
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// 失败子状态:
        /// FILE_NOT_FOUND:文件不存在
        /// FILE_ABNORMAL:文件异常
        /// FILE_ABNORMAL_DEAL_RECOVER:恢复文件时，文件异常
        /// BACKUP_FILE_NOT_FOUND:备份文件不存在
        /// CONTAINER_NOT_FOUND_DEAL_ISOLATE:隔离时，容器不存在
        /// CONTAINER_NOT_FOUND_DEAL_RECOVER:恢复时，容器不存在
        /// </summary>
        [JsonProperty("SubStatus")]
        public string SubStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "HarmDescribe", this.HarmDescribe);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "SubStatus", this.SubStatus);
        }
    }
}

