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

namespace TencentCloud.Vm.V20201229
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vm.V20201229.Models;

   public class VmClient : AbstractClient{

       private const string endpoint = "vm.tencentcloudapi.com";
       private const string version = "2020-12-29";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 可使用该接口取消审核任务，成功取消后，该接口返回已取消任务的TaskId。<br>
        /// 
        /// 默认接口请求频率限制：**20次/秒**。
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public async Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可使用该接口取消审核任务，成功取消后，该接口返回已取消任务的TaskId。<br>
        /// 
        /// 默认接口请求频率限制：**20次/秒**。
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（Video Moderation System，VM）用于提交视频文件或视频流进行智能审核任务。使用前请您使用腾讯云主账号登录控制台[开通视频内容安全服务](https://console.cloud.tencent.com/cms/video/package)并调整好对应的业务配置。<br>
        /// ### 功能使用说明：
        /// 
        /// - 前往“[内容安全控制台-视频内容安全](https://console.cloud.tencent.com/cms/video/package)”开启使用视频内容安全服务，首次开通服务的用户可免费领用试用套餐包，包含600分钟的处理量（换算1s每帧截图，赠送**36000张图**、**600分钟的音频**处理量），有效期为1个月。
        /// 
        /// - 该接口为收费接口，计费方式敬请参见[腾讯云视频内容安全定价](https://cloud.tencent.com/product/vm/pricing)。
        /// 
        /// - 默认接口请求频率限制：**20次/秒**，对于异步审核任务（点播视频），超出频率限制的请求会自动排入待审核队列，对于同步审核任务（直播视频），超出频率限制将会报错。
        /// - 默认并发审核路数限制：10路，异步审核任务（点播视频）数量超过并发审核路数时，将会进入排队；同步审核任务（直播视频）超过并发审核路数，接口会返回错误。
        /// 
        /// 
        /// ### 接口功能说明：
        /// 
        /// - 支持对视频文件或视频流进行自动检测，从 OCR文本识别、物体检测（实体、广告台标、二维码等）、图像识别及音频审核四个维度，通过深度学习技术识别视频中的违规内容；
        /// - 支持设置回调地址 Callback 获取检测结果，或通过接口(查看任务详情)主动轮询获取检测结果详情；对于正常审核中的视频任务，如含有违规内容，则截帧图片最长会在**3s**内回调，音频片段会在用户配置的**切片时长 + 2s**内回调；对于在队列中的待审核任务，回调时间为正常审核回调时间+等待时间；
        /// - 支持通过接口（查看审核任务列表）查询任务队列，用户可根据多种业务信息（业务类型、审核结果、任务状态等）筛选审核任务列表；
        /// - 支持识别多种违规场景，包括：低俗、谩骂、色情、广告等场景；
        /// - 支持根据不同的业务场景配置自定义的审核策略；
        /// - 支持用户自定义配置黑白词库及图片库，打击自定义违规内容（目前仅支持黑名单配置）；
        /// - 支持用户自定义配置审核任务优先级，当有多个任务排队时，可根据用户配置自动调整任务优先级；
        /// - 支持批量提交检测任务，**最多可同时创建10个任务**；
        /// 
        /// ### 视频文件调用说明：
        /// 
        /// - 视频文件大小支持：**文件 < 3GB**
        /// - 视频文件分辨率支持：**最佳分辨率为1920x1080 (1080p)**，如果视频文件小于300MB，则分辨率可以大于1080p，更大视频可以调用[云转码服务](https://cloud.tencent.com/product/mps/details)转码后再送审；
        /// - 视频文件支持格式：flv、mkv 、mp4 、rmvb 、avi 、wmv、3gp、ts、mov、rm、mpeg、wmf等。
        /// - 视频文件支持的访问方式：链接地址（支持HTTP/HTTPS）、腾讯云COS存储；
        /// - 若传入视频文件的访问链接，则需要注意视频**头文件的读取时间限制为3秒**，为保障被检测视频的稳定性和可靠性，建议您使用腾讯云COS存储或者CDN缓存等；
        /// - 支持用户配置是否需要开启音频审核，若不开启则将仅对视频文件图像内容进行审核。
        /// 
        /// ### 视频流调用说明：
        /// 
        /// - 视频流时长支持：**5小时以内**
        /// - 视频流分辨率支持：支持**1920x1080 (1080p)**，更高分辨率视频可以调用[直播云转码服务](https://cloud.tencent.com/document/product/267/39889)转码后再送审；
        /// - 视频流支持格式：rmtp，flv 等主流视频流编码格式。
        /// - 视频文件支持的传输协议：HTTP/HTTPS/RTMP；
        /// - 支持用户配置是否需要开启音频审核，若不开启则将仅对视频流图像内容进行审核。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoModerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoModerationTaskResponse"/></returns>
        public async Task<CreateVideoModerationTaskResponse> CreateVideoModerationTask(CreateVideoModerationTaskRequest req)
        {
             JsonResponseModel<CreateVideoModerationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVideoModerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoModerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（Video Moderation System，VM）用于提交视频文件或视频流进行智能审核任务。使用前请您使用腾讯云主账号登录控制台[开通视频内容安全服务](https://console.cloud.tencent.com/cms/video/package)并调整好对应的业务配置。<br>
        /// ### 功能使用说明：
        /// 
        /// - 前往“[内容安全控制台-视频内容安全](https://console.cloud.tencent.com/cms/video/package)”开启使用视频内容安全服务，首次开通服务的用户可免费领用试用套餐包，包含600分钟的处理量（换算1s每帧截图，赠送**36000张图**、**600分钟的音频**处理量），有效期为1个月。
        /// 
        /// - 该接口为收费接口，计费方式敬请参见[腾讯云视频内容安全定价](https://cloud.tencent.com/product/vm/pricing)。
        /// 
        /// - 默认接口请求频率限制：**20次/秒**，对于异步审核任务（点播视频），超出频率限制的请求会自动排入待审核队列，对于同步审核任务（直播视频），超出频率限制将会报错。
        /// - 默认并发审核路数限制：10路，异步审核任务（点播视频）数量超过并发审核路数时，将会进入排队；同步审核任务（直播视频）超过并发审核路数，接口会返回错误。
        /// 
        /// 
        /// ### 接口功能说明：
        /// 
        /// - 支持对视频文件或视频流进行自动检测，从 OCR文本识别、物体检测（实体、广告台标、二维码等）、图像识别及音频审核四个维度，通过深度学习技术识别视频中的违规内容；
        /// - 支持设置回调地址 Callback 获取检测结果，或通过接口(查看任务详情)主动轮询获取检测结果详情；对于正常审核中的视频任务，如含有违规内容，则截帧图片最长会在**3s**内回调，音频片段会在用户配置的**切片时长 + 2s**内回调；对于在队列中的待审核任务，回调时间为正常审核回调时间+等待时间；
        /// - 支持通过接口（查看审核任务列表）查询任务队列，用户可根据多种业务信息（业务类型、审核结果、任务状态等）筛选审核任务列表；
        /// - 支持识别多种违规场景，包括：低俗、谩骂、色情、广告等场景；
        /// - 支持根据不同的业务场景配置自定义的审核策略；
        /// - 支持用户自定义配置黑白词库及图片库，打击自定义违规内容（目前仅支持黑名单配置）；
        /// - 支持用户自定义配置审核任务优先级，当有多个任务排队时，可根据用户配置自动调整任务优先级；
        /// - 支持批量提交检测任务，**最多可同时创建10个任务**；
        /// 
        /// ### 视频文件调用说明：
        /// 
        /// - 视频文件大小支持：**文件 < 3GB**
        /// - 视频文件分辨率支持：**最佳分辨率为1920x1080 (1080p)**，如果视频文件小于300MB，则分辨率可以大于1080p，更大视频可以调用[云转码服务](https://cloud.tencent.com/product/mps/details)转码后再送审；
        /// - 视频文件支持格式：flv、mkv 、mp4 、rmvb 、avi 、wmv、3gp、ts、mov、rm、mpeg、wmf等。
        /// - 视频文件支持的访问方式：链接地址（支持HTTP/HTTPS）、腾讯云COS存储；
        /// - 若传入视频文件的访问链接，则需要注意视频**头文件的读取时间限制为3秒**，为保障被检测视频的稳定性和可靠性，建议您使用腾讯云COS存储或者CDN缓存等；
        /// - 支持用户配置是否需要开启音频审核，若不开启则将仅对视频文件图像内容进行审核。
        /// 
        /// ### 视频流调用说明：
        /// 
        /// - 视频流时长支持：**5小时以内**
        /// - 视频流分辨率支持：支持**1920x1080 (1080p)**，更高分辨率视频可以调用[直播云转码服务](https://cloud.tencent.com/document/product/267/39889)转码后再送审；
        /// - 视频流支持格式：rmtp，flv 等主流视频流编码格式。
        /// - 视频文件支持的传输协议：HTTP/HTTPS/RTMP；
        /// - 支持用户配置是否需要开启音频审核，若不开启则将仅对视频流图像内容进行审核。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoModerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoModerationTaskResponse"/></returns>
        public CreateVideoModerationTaskResponse CreateVideoModerationTaskSync(CreateVideoModerationTaskRequest req)
        {
             JsonResponseModel<CreateVideoModerationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVideoModerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoModerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过查看任务详情 DescribeTaskDetail 接口，可主动轮询获取检测结果详情。<br>
        /// 
        /// 默认接口请求频率限制：**200次/秒**。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过查看任务详情 DescribeTaskDetail 接口，可主动轮询获取检测结果详情。<br>
        /// 
        /// 默认接口请求频率限制：**200次/秒**。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过查看审核任务列表接口，可查询任务队列；您可根据多种业务信息（业务类型、审核结果、任务状态等）筛选审核任务列表。<br>
        /// 
        /// 默认接口请求频率限制：**20次/秒**。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过查看审核任务列表接口，可查询任务队列；您可根据多种业务信息（业务类型、审核结果、任务状态等）筛选审核任务列表。<br>
        /// 
        /// 默认接口请求频率限制：**20次/秒**。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
