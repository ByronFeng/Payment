using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMicropayOrderDirectPayResponse.
    /// </summary>
    public class AlipayMicropayOrderDirectPayResponse : AlipayResponse
    {
        /// <summary>
        /// 单笔直接支付返回结果
        /// </summary>
        [JsonProperty("single_pay_detail")]
        public SinglePayDetail SinglePayDetail { get; set; }
    }
}
