using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Picture Data Structure.
    /// </summary>
    public class Picture : AlipayObject
    {
        /// <summary>
        /// 调用alipay.offline.material.image.upload接口将图片上传到素材中心后，生成的ID
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
