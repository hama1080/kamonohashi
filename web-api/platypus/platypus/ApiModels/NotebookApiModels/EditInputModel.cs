﻿using System.ComponentModel.DataAnnotations;

namespace Nssol.Platypus.ApiModels.NotebookApiModels
{
    public class EditInputModel
    {
        /// <summary>
        /// ノートブック名
        /// </summary>
        [MinLength(1)]
        public string Name { get; set; }

        /// <summary>
        /// メモ
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// お気に入り
        /// </summary>
        public bool? Favorite { get; set; }
    }
}
