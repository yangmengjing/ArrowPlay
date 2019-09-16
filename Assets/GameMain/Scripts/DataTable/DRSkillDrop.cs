﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2019-09-16 10:28:19.813
//------------------------------------------------------------

using GameFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace ArrowPlay
{
    /// <summary>
    /// 技能掉落组。
    /// </summary>
    public class DRSkillDrop : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取技能id。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取名字。
        /// </summary>
        public string Skill
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取描述。
        /// </summary>
        public string Description
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取特效名称。
        /// </summary>
        public string Preferb
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取场景1掉落权重。
        /// </summary>
        public int Scene1Weight
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取场景2掉落权重。
        /// </summary>
        public int Scene2Weight
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取场景3掉落权重。
        /// </summary>
        public int Scene3Weight
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取场景4掉落权重。
        /// </summary>
        public int Scene4Weight
        {
            get;
            private set;
        }

        public override bool ParseDataRow(GameFrameworkSegment<string> dataRowSegment)
        {
            // Arrow Play 示例代码，正式项目使用时请调整此处的生成代码，以处理 GCAlloc 问题！
            string[] columnTexts = dataRowSegment.Source.Substring(dataRowSegment.Offset, dataRowSegment.Length).Split(DataTableExtension.DataSplitSeparators);
            for (int i = 0; i < columnTexts.Length; i++)
            {
                columnTexts[i] = columnTexts[i].Trim(DataTableExtension.DataTrimSeparators);
            }

            int index = 0;
            index++;
            m_Id = int.Parse(columnTexts[index++]);
            Skill = columnTexts[index++];
            Description = columnTexts[index++];
            Preferb = columnTexts[index++];
            Scene1Weight = int.Parse(columnTexts[index++]);
            Scene2Weight = int.Parse(columnTexts[index++]);
            Scene3Weight = int.Parse(columnTexts[index++]);
            Scene4Weight = int.Parse(columnTexts[index++]);

            GeneratePropertyArray();
            return true;
        }

        public override bool ParseDataRow(GameFrameworkSegment<byte[]> dataRowSegment)
        {
            // Arrow Play 示例代码，正式项目使用时请调整此处的生成代码，以处理 GCAlloc 问题！
            using (MemoryStream memoryStream = new MemoryStream(dataRowSegment.Source, dataRowSegment.Offset, dataRowSegment.Length, false))
            {
                using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                {
                    m_Id = binaryReader.ReadInt32();
                    Skill = binaryReader.ReadString();
                    Description = binaryReader.ReadString();
                    Preferb = binaryReader.ReadString();
                    Scene1Weight = binaryReader.ReadInt32();
                    Scene2Weight = binaryReader.ReadInt32();
                    Scene3Weight = binaryReader.ReadInt32();
                    Scene4Weight = binaryReader.ReadInt32();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        public override bool ParseDataRow(GameFrameworkSegment<Stream> dataRowSegment)
        {
            Log.Warning("Not implemented ParseDataRow(GameFrameworkSegment<Stream>)");
            return false;
        }

        private void GeneratePropertyArray()
        {

        }
    }
}
