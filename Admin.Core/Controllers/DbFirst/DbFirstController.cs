﻿using Admin.Core.Common.DB;
using Admin.Core.Model;
using Admin.Core.Model.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SqlSugar;
using System.Linq;

namespace Admin.Core.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize(Permissions.Name)]
    public class DbFirstController : ControllerBase
    {
        private readonly SqlSugarClient _sqlSugarClient;
        private readonly IWebHostEnvironment Env;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DbFirstController(ISqlSugarClient sqlSugarClient, IWebHostEnvironment env)
        {
            _sqlSugarClient = sqlSugarClient as SqlSugarClient;
            Env = env;
        }

        /// <summary>
        /// 获取 整体框架 文件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MessageModel<string> GetFrameFiles()
        {
            var data = new MessageModel<string>() { success = true, msg = "" };
            if (Env.IsDevelopment())
            {
                BaseDBConfig.MutiConnectionString.Item1.ToList().ForEach(m =>
                {
                    _sqlSugarClient.ChangeDatabase(m.ConnId.ToLower());
                    data.response += $"库{m.ConnId}-Model层生成：{FrameSeed.CreateModels(_sqlSugarClient, m.ConnId)} || ";
                    data.response += $"库{m.ConnId}-IRepositorys层生成：{FrameSeed.CreateIRepositorys(_sqlSugarClient, m.ConnId)} || ";
                    data.response += $"库{m.ConnId}-IServices层生成：{FrameSeed.CreateIServices(_sqlSugarClient, m.ConnId)} || ";
                    data.response += $"库{m.ConnId}-Repository层生成：{FrameSeed.CreateRepository(_sqlSugarClient, m.ConnId)} || ";
                    data.response += $"库{m.ConnId}-Services层生成：{FrameSeed.CreateServices(_sqlSugarClient, m.ConnId)} || ";
                });

                // 切回主库
                _sqlSugarClient.ChangeDatabase(MainDb.CurrentDbConnId.ToLower());
            }
            else
            {
                data.success = false;
                data.msg = "当前不处于开发模式，代码生成不可用！";
            }

            return data;
        }

        /// <summary>
        /// 根据数据库表名 生成整体框架
        /// 仅针对通过CodeFirst生成表的情况
        /// </summary>
        /// <param name="ConnID">数据库链接名称</param>
        /// <param name="tableNames">需要生成的表名</param>
        /// <returns></returns>
        [HttpPost]
        public MessageModel<string> GetFrameFilesByTableNames([FromBody]string[] tableNames, [FromQuery]string ConnID = null)
        {
            ConnID = ConnID == null ? MainDb.CurrentDbConnId.ToLower() : ConnID;

            var data = new MessageModel<string>() { success = true, msg = "" };
            if (Env.IsDevelopment())
            {

                data.response += $"库{ConnID}-IRepositorys层生成：{FrameSeed.CreateIRepositorys(_sqlSugarClient, ConnID, tableNames)} || ";
                data.response += $"库{ConnID}-IServices层生成：{FrameSeed.CreateIServices(_sqlSugarClient, ConnID, tableNames)} || ";
                data.response += $"库{ConnID}-Repository层生成：{FrameSeed.CreateRepository(_sqlSugarClient, ConnID, tableNames)} || ";
                data.response += $"库{ConnID}-Services层生成：{FrameSeed.CreateServices(_sqlSugarClient, ConnID, tableNames)} || ";
            }
            else
            {
                data.success = false;
                data.msg = "当前不处于开发模式，代码生成不可用！";
            }

            return data;
        }
    }
}