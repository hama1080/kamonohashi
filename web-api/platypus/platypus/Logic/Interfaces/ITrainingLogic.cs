﻿using Nssol.Platypus.Infrastructure;
using Nssol.Platypus.Models.TenantModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nssol.Platypus.Logic.Interfaces
{
    /// <summary>
    /// Job系の操作で、<see cref="Controllers.spa.TrainingController"/>以外からも使用したい処理をまとめたロジック
    /// </summary>
    public interface ITrainingLogic
    {
        /// <summary>
        /// 学習履歴コンテナを削除し、ステータスを変更する。
        /// </summary>
        /// <param name="trainingHistory">対象学習履歴</param>
        /// <param name="status">変更後のステータス</param>
        /// <param name="force">他テナントに対する変更を許可するか</param>
        Task ExitAsync(TrainingHistory trainingHistory, ContainerStatus status, bool force);

        /// <summary>
        /// TensorBoardコンテナを削除する。
        /// </summary>
        /// <param name="container">対象コンテナ</param>
        /// <param name="force">他テナントに対する変更を許可するか</param>
        Task DeleteTensorBoardAsync(TensorBoardContainer container, bool force);
    }
}
