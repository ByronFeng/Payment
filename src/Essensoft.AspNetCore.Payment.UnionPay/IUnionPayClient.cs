﻿using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public interface IUnionPayClient
    {
        /// <summary>
        /// 执行UnionPay API请求。
        /// </summary>
        /// <param name="request">具体的JdPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IUnionPayRequest<T> request) where T : UnionPayResponse;

        /// <summary>
        /// 执行UnionPay API请求。
        /// </summary>
        /// <param name="request">具体的JdPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request, string reqMethod) where T : UnionPayResponse;
    }
}
