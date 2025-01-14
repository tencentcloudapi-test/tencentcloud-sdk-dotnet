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

namespace TencentCloud.Cloudaudit.V20190319
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudaudit.V20190319.Models;

   public class CloudauditClient : AbstractClient{

       private const string endpoint = "cloudaudit.tencentcloudapi.com";
       private const string version = "2019-03-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudauditClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudauditClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 参数要求：
        /// 1、如果IsCreateNewBucket的值存在的话，cosRegion和cosBucketName都是必填参数。
        /// 2、如果IsEnableCmqNotify的值是1的话，IsCreateNewQueue、CmqRegion和CmqQueueName都是必填参数。
        /// 3、如果IsEnableCmqNotify的值是0的话，IsCreateNewQueue、CmqRegion和CmqQueueName都不能传。
        /// 4、如果IsEnableKmsEncry的值是1的话，KmsRegion和KeyId属于必填项
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRequest"/></param>
        /// <returns><see cref="CreateAuditResponse"/></returns>
        public async Task<CreateAuditResponse> CreateAudit(CreateAuditRequest req)
        {
             JsonResponseModel<CreateAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 参数要求：
        /// 1、如果IsCreateNewBucket的值存在的话，cosRegion和cosBucketName都是必填参数。
        /// 2、如果IsEnableCmqNotify的值是1的话，IsCreateNewQueue、CmqRegion和CmqQueueName都是必填参数。
        /// 3、如果IsEnableCmqNotify的值是0的话，IsCreateNewQueue、CmqRegion和CmqQueueName都不能传。
        /// 4、如果IsEnableKmsEncry的值是1的话，KmsRegion和KeyId属于必填项
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRequest"/></param>
        /// <returns><see cref="CreateAuditResponse"/></returns>
        public CreateAuditResponse CreateAuditSync(CreateAuditRequest req)
        {
             JsonResponseModel<CreateAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建跟踪集
        /// </summary>
        /// <param name="req"><see cref="CreateAuditTrackRequest"/></param>
        /// <returns><see cref="CreateAuditTrackResponse"/></returns>
        public async Task<CreateAuditTrackResponse> CreateAuditTrack(CreateAuditTrackRequest req)
        {
             JsonResponseModel<CreateAuditTrackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAuditTrack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuditTrackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建跟踪集
        /// </summary>
        /// <param name="req"><see cref="CreateAuditTrackRequest"/></param>
        /// <returns><see cref="CreateAuditTrackResponse"/></returns>
        public CreateAuditTrackResponse CreateAuditTrackSync(CreateAuditTrackRequest req)
        {
             JsonResponseModel<CreateAuditTrackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAuditTrack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuditTrackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除跟踪集
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRequest"/></param>
        /// <returns><see cref="DeleteAuditResponse"/></returns>
        public async Task<DeleteAuditResponse> DeleteAudit(DeleteAuditRequest req)
        {
             JsonResponseModel<DeleteAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除跟踪集
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRequest"/></param>
        /// <returns><see cref="DeleteAuditResponse"/></returns>
        public DeleteAuditResponse DeleteAuditSync(DeleteAuditRequest req)
        {
             JsonResponseModel<DeleteAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditTrackRequest"/></param>
        /// <returns><see cref="DeleteAuditTrackResponse"/></returns>
        public async Task<DeleteAuditTrackResponse> DeleteAuditTrack(DeleteAuditTrackRequest req)
        {
             JsonResponseModel<DeleteAuditTrackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAuditTrack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAuditTrackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云审计跟踪集
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditTrackRequest"/></param>
        /// <returns><see cref="DeleteAuditTrackResponse"/></returns>
        public DeleteAuditTrackResponse DeleteAuditTrackSync(DeleteAuditTrackRequest req)
        {
             JsonResponseModel<DeleteAuditTrackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAuditTrack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAuditTrackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跟踪集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRequest"/></param>
        /// <returns><see cref="DescribeAuditResponse"/></returns>
        public async Task<DescribeAuditResponse> DescribeAudit(DescribeAuditRequest req)
        {
             JsonResponseModel<DescribeAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跟踪集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRequest"/></param>
        /// <returns><see cref="DescribeAuditResponse"/></returns>
        public DescribeAuditResponse DescribeAuditSync(DescribeAuditRequest req)
        {
             JsonResponseModel<DescribeAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计跟踪集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTracksRequest"/></param>
        /// <returns><see cref="DescribeAuditTracksResponse"/></returns>
        public async Task<DescribeAuditTracksResponse> DescribeAuditTracks(DescribeAuditTracksRequest req)
        {
             JsonResponseModel<DescribeAuditTracksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuditTracks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditTracksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计跟踪集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTracksRequest"/></param>
        /// <returns><see cref="DescribeAuditTracksResponse"/></returns>
        public DescribeAuditTracksResponse DescribeAuditTracksSync(DescribeAuditTracksRequest req)
        {
             JsonResponseModel<DescribeAuditTracksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuditTracks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditTracksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public async Task<DescribeEventsResponse> DescribeEvents(DescribeEventsRequest req)
        {
             JsonResponseModel<DescribeEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public DescribeEventsResponse DescribeEventsSync(DescribeEventsRequest req)
        {
             JsonResponseModel<DescribeEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询AttributeKey的有效取值范围
        /// </summary>
        /// <param name="req"><see cref="GetAttributeKeyRequest"/></param>
        /// <returns><see cref="GetAttributeKeyResponse"/></returns>
        public async Task<GetAttributeKeyResponse> GetAttributeKey(GetAttributeKeyRequest req)
        {
             JsonResponseModel<GetAttributeKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAttributeKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttributeKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询AttributeKey的有效取值范围
        /// </summary>
        /// <param name="req"><see cref="GetAttributeKeyRequest"/></param>
        /// <returns><see cref="GetAttributeKeyResponse"/></returns>
        public GetAttributeKeyResponse GetAttributeKeySync(GetAttributeKeyRequest req)
        {
             JsonResponseModel<GetAttributeKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAttributeKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttributeKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户可创建跟踪集的数量
        /// </summary>
        /// <param name="req"><see cref="InquireAuditCreditRequest"/></param>
        /// <returns><see cref="InquireAuditCreditResponse"/></returns>
        public async Task<InquireAuditCreditResponse> InquireAuditCredit(InquireAuditCreditRequest req)
        {
             JsonResponseModel<InquireAuditCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquireAuditCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquireAuditCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户可创建跟踪集的数量
        /// </summary>
        /// <param name="req"><see cref="InquireAuditCreditRequest"/></param>
        /// <returns><see cref="InquireAuditCreditResponse"/></returns>
        public InquireAuditCreditResponse InquireAuditCreditSync(InquireAuditCreditRequest req)
        {
             JsonResponseModel<InquireAuditCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquireAuditCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquireAuditCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跟踪集概要
        /// </summary>
        /// <param name="req"><see cref="ListAuditsRequest"/></param>
        /// <returns><see cref="ListAuditsResponse"/></returns>
        public async Task<ListAuditsResponse> ListAudits(ListAuditsRequest req)
        {
             JsonResponseModel<ListAuditsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAudits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuditsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跟踪集概要
        /// </summary>
        /// <param name="req"><see cref="ListAuditsRequest"/></param>
        /// <returns><see cref="ListAuditsResponse"/></returns>
        public ListAuditsResponse ListAuditsSync(ListAuditsRequest req)
        {
             JsonResponseModel<ListAuditsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAudits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuditsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计支持的cmq的可用区
        /// </summary>
        /// <param name="req"><see cref="ListCmqEnableRegionRequest"/></param>
        /// <returns><see cref="ListCmqEnableRegionResponse"/></returns>
        public async Task<ListCmqEnableRegionResponse> ListCmqEnableRegion(ListCmqEnableRegionRequest req)
        {
             JsonResponseModel<ListCmqEnableRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListCmqEnableRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCmqEnableRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计支持的cmq的可用区
        /// </summary>
        /// <param name="req"><see cref="ListCmqEnableRegionRequest"/></param>
        /// <returns><see cref="ListCmqEnableRegionResponse"/></returns>
        public ListCmqEnableRegionResponse ListCmqEnableRegionSync(ListCmqEnableRegionRequest req)
        {
             JsonResponseModel<ListCmqEnableRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListCmqEnableRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCmqEnableRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计支持的cos可用区
        /// </summary>
        /// <param name="req"><see cref="ListCosEnableRegionRequest"/></param>
        /// <returns><see cref="ListCosEnableRegionResponse"/></returns>
        public async Task<ListCosEnableRegionResponse> ListCosEnableRegion(ListCosEnableRegionRequest req)
        {
             JsonResponseModel<ListCosEnableRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListCosEnableRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCosEnableRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云审计支持的cos可用区
        /// </summary>
        /// <param name="req"><see cref="ListCosEnableRegionRequest"/></param>
        /// <returns><see cref="ListCosEnableRegionResponse"/></returns>
        public ListCosEnableRegionResponse ListCosEnableRegionSync(ListCosEnableRegionRequest req)
        {
             JsonResponseModel<ListCosEnableRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListCosEnableRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCosEnableRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据地域获取KMS密钥别名
        /// </summary>
        /// <param name="req"><see cref="ListKeyAliasByRegionRequest"/></param>
        /// <returns><see cref="ListKeyAliasByRegionResponse"/></returns>
        public async Task<ListKeyAliasByRegionResponse> ListKeyAliasByRegion(ListKeyAliasByRegionRequest req)
        {
             JsonResponseModel<ListKeyAliasByRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListKeyAliasByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeyAliasByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据地域获取KMS密钥别名
        /// </summary>
        /// <param name="req"><see cref="ListKeyAliasByRegionRequest"/></param>
        /// <returns><see cref="ListKeyAliasByRegionResponse"/></returns>
        public ListKeyAliasByRegionResponse ListKeyAliasByRegionSync(ListKeyAliasByRegionRequest req)
        {
             JsonResponseModel<ListKeyAliasByRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListKeyAliasByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListKeyAliasByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对操作日志进行检索，便于用户进行查询相关的操作信息。
        /// </summary>
        /// <param name="req"><see cref="LookUpEventsRequest"/></param>
        /// <returns><see cref="LookUpEventsResponse"/></returns>
        public async Task<LookUpEventsResponse> LookUpEvents(LookUpEventsRequest req)
        {
             JsonResponseModel<LookUpEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LookUpEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LookUpEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对操作日志进行检索，便于用户进行查询相关的操作信息。
        /// </summary>
        /// <param name="req"><see cref="LookUpEventsRequest"/></param>
        /// <returns><see cref="LookUpEventsResponse"/></returns>
        public LookUpEventsResponse LookUpEventsSync(LookUpEventsRequest req)
        {
             JsonResponseModel<LookUpEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LookUpEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LookUpEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云审计跟踪
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditTrackRequest"/></param>
        /// <returns><see cref="ModifyAuditTrackResponse"/></returns>
        public async Task<ModifyAuditTrackResponse> ModifyAuditTrack(ModifyAuditTrackRequest req)
        {
             JsonResponseModel<ModifyAuditTrackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAuditTrack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAuditTrackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云审计跟踪
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditTrackRequest"/></param>
        /// <returns><see cref="ModifyAuditTrackResponse"/></returns>
        public ModifyAuditTrackResponse ModifyAuditTrackSync(ModifyAuditTrackRequest req)
        {
             JsonResponseModel<ModifyAuditTrackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAuditTrack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAuditTrackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启跟踪集
        /// </summary>
        /// <param name="req"><see cref="StartLoggingRequest"/></param>
        /// <returns><see cref="StartLoggingResponse"/></returns>
        public async Task<StartLoggingResponse> StartLogging(StartLoggingRequest req)
        {
             JsonResponseModel<StartLoggingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartLogging");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartLoggingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启跟踪集
        /// </summary>
        /// <param name="req"><see cref="StartLoggingRequest"/></param>
        /// <returns><see cref="StartLoggingResponse"/></returns>
        public StartLoggingResponse StartLoggingSync(StartLoggingRequest req)
        {
             JsonResponseModel<StartLoggingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartLogging");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartLoggingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭跟踪集
        /// </summary>
        /// <param name="req"><see cref="StopLoggingRequest"/></param>
        /// <returns><see cref="StopLoggingResponse"/></returns>
        public async Task<StopLoggingResponse> StopLogging(StopLoggingRequest req)
        {
             JsonResponseModel<StopLoggingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopLogging");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLoggingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭跟踪集
        /// </summary>
        /// <param name="req"><see cref="StopLoggingRequest"/></param>
        /// <returns><see cref="StopLoggingResponse"/></returns>
        public StopLoggingResponse StopLoggingSync(StopLoggingRequest req)
        {
             JsonResponseModel<StopLoggingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopLogging");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLoggingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 参数要求：
        /// 1、如果IsCreateNewBucket的值存在的话，cosRegion和cosBucketName都是必填参数。
        /// 2、如果IsEnableCmqNotify的值是1的话，IsCreateNewQueue、CmqRegion和CmqQueueName都是必填参数。
        /// 3、如果IsEnableCmqNotify的值是0的话，IsCreateNewQueue、CmqRegion和CmqQueueName都不能传。
        /// 4、如果IsEnableKmsEncry的值是1的话，KmsRegion和KeyId属于必填项
        /// </summary>
        /// <param name="req"><see cref="UpdateAuditRequest"/></param>
        /// <returns><see cref="UpdateAuditResponse"/></returns>
        public async Task<UpdateAuditResponse> UpdateAudit(UpdateAuditRequest req)
        {
             JsonResponseModel<UpdateAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 参数要求：
        /// 1、如果IsCreateNewBucket的值存在的话，cosRegion和cosBucketName都是必填参数。
        /// 2、如果IsEnableCmqNotify的值是1的话，IsCreateNewQueue、CmqRegion和CmqQueueName都是必填参数。
        /// 3、如果IsEnableCmqNotify的值是0的话，IsCreateNewQueue、CmqRegion和CmqQueueName都不能传。
        /// 4、如果IsEnableKmsEncry的值是1的话，KmsRegion和KeyId属于必填项
        /// </summary>
        /// <param name="req"><see cref="UpdateAuditRequest"/></param>
        /// <returns><see cref="UpdateAuditResponse"/></returns>
        public UpdateAuditResponse UpdateAuditSync(UpdateAuditRequest req)
        {
             JsonResponseModel<UpdateAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
