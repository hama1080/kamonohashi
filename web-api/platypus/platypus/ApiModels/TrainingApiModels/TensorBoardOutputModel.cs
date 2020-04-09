﻿using Nssol.Platypus.Infrastructure;
using Nssol.Platypus.Models.TenantModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nssol.Platypus.ApiModels.TrainingApiModels
{
    public class TensorBoardOutputModel
    {
        public TensorBoardOutputModel(TensorBoardContainer container, ContainerStatus status, string endpoint = null)
        {
            Status = status.Name;
            StatusType = status.StatusType;

            if (container != null)
            {
                Name = container.Name;
                if (status.Exist() && string.IsNullOrEmpty(container.Host) == false)
                {
                    // リバプロを介したアクセスパスを返す
                    Path = "nodeport/" + container.PortNo.ToString();
                }
            }
        }

        /// <summary>
        /// コンテナ名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ステータス
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// ステータス詳細
        /// </summary>
        public string StatusType { get; set; }
        /// <summary>
        /// アクセスパス
        /// </summary>
        public string Path { get; set; }
    }
}
