﻿/****************************************************************************
*Copyright (c) 2018 Microsoft All Rights Reserved.
*CLR版本： 2.1.4
*机器名称：WENLI-PC
*公司名称：wenli
*命名空间：SAEA.Commom
*文件名： Extentions
*版本号： V1.0.0.0
*唯一标识：ef84e44b-6fa2-432e-90a2-003ebd059303
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/3/1 15:54:21
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/3/1 15:54:21
*修改人： yswenli
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEA.Common
{
    public static class Extentions
    {
        public static Dictionary<T1, T2> TryAdd<T1, T2>(this Dictionary<T1, T2> dic, T1 t1, T2 t2)
        {
            if (dic != null)
            {
                if (!dic.ContainsKey(t1))
                {
                    dic.Add(t1, t2);
                }
                else
                {
                    dic[t1] = t2;
                }
            }
            return dic;
        }
    }
}
