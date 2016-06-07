﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class KETQUAXOSO_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public KETQUAXOSO_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public string Insert(KETQUAXOSO ketqua)
        {
            var MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = ketqua.MaDotPhatHanh
            };
            var MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Value = ketqua.MaLoaiVe
            };
            var MaKetQuaXoSo = new SqlParameter("@MaKetQuaXoSo", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("KETQUAXOSO_Ins @MaDotPhatHanh, @MaLoaiVe, @MaKetQuaXoSo out", MaDotPhatHanh, MaLoaiVe, MaKetQuaXoSo);
            return MaKetQuaXoSo.Value.ToString();
        }
    }
}
