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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SslVpnSever : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID.
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// SSL-VPN-SERVER 实例ID。
        /// </summary>
        [JsonProperty("SslVpnServerId")]
        public string SslVpnServerId{ get; set; }

        /// <summary>
        /// VPN 实例ID。
        /// </summary>
        [JsonProperty("VpnGatewayId")]
        public string VpnGatewayId{ get; set; }

        /// <summary>
        /// SSL-VPN-SERVER name。
        /// </summary>
        [JsonProperty("SslVpnServerName")]
        public string SslVpnServerName{ get; set; }

        /// <summary>
        /// 本端地址段。
        /// </summary>
        [JsonProperty("LocalAddress")]
        public string[] LocalAddress{ get; set; }

        /// <summary>
        /// 客户端地址段。
        /// </summary>
        [JsonProperty("RemoteAddress")]
        public string RemoteAddress{ get; set; }

        /// <summary>
        /// 客户端最大连接数。
        /// </summary>
        [JsonProperty("MaxConnection")]
        public ulong? MaxConnection{ get; set; }

        /// <summary>
        /// SSL-VPN 网关公网IP。
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// SSL VPN服务端监听协议
        /// </summary>
        [JsonProperty("SslVpnProtocol")]
        public string SslVpnProtocol{ get; set; }

        /// <summary>
        /// SSL VPN服务端监听协议端口
        /// </summary>
        [JsonProperty("SslVpnPort")]
        public ulong? SslVpnPort{ get; set; }

        /// <summary>
        /// 加密算法。
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// 认证算法。
        /// </summary>
        [JsonProperty("IntegrityAlgorithm")]
        public string IntegrityAlgorithm{ get; set; }

        /// <summary>
        /// 是否支持压缩。
        /// </summary>
        [JsonProperty("Compress")]
        public ulong? Compress{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// SSL-VPN-SERVER 创建状态。
        /// 0 创建中
        /// 1 创建出错
        /// 2 更新中
        /// 3 更新出错
        /// 4 销毁中
        /// 5 销毁出粗
        /// 6 已连通
        /// 7 未知
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SslVpnServerId", this.SslVpnServerId);
            this.SetParamSimple(map, prefix + "VpnGatewayId", this.VpnGatewayId);
            this.SetParamSimple(map, prefix + "SslVpnServerName", this.SslVpnServerName);
            this.SetParamArraySimple(map, prefix + "LocalAddress.", this.LocalAddress);
            this.SetParamSimple(map, prefix + "RemoteAddress", this.RemoteAddress);
            this.SetParamSimple(map, prefix + "MaxConnection", this.MaxConnection);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "SslVpnProtocol", this.SslVpnProtocol);
            this.SetParamSimple(map, prefix + "SslVpnPort", this.SslVpnPort);
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamSimple(map, prefix + "IntegrityAlgorithm", this.IntegrityAlgorithm);
            this.SetParamSimple(map, prefix + "Compress", this.Compress);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

