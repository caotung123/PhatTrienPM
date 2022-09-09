using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLThietBi;
using System.Data;
using System.Windows.Forms;
using System.Data.Linq;
namespace DAL_QLThietBi
{
    public class DAL_DonNhap
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_DonNhap()
        {

        }
        public List<DONNHAP> loadDonNhap()
        {
            return db_LinhKien.DONNHAPs.Select(t => t).ToList();
        }
        public int themDonNhap(DONNHAP dn)
        {
            try
            {
                db_LinhKien.DONNHAPs.InsertOnSubmit(dn);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaDonNhap(DONNHAP dn)
        {
            try
            {
                db_LinhKien.DONNHAPs.DeleteOnSubmit(dn);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaDonNhap(DONNHAP pDN)
        {
            try
            {
                DONNHAP dn = db_LinhKien.DONNHAPs.Where(t => t.MADN == pDN.MADN).FirstOrDefault();
                dn = pDN;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuDonNhap()
        {
            try
            {
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public DONNHAP timDonNhapTheoMa(int pMaDN)
        {
            try
            {
                return db_LinhKien.DONNHAPs.Select(t => t).Where(t => t.MADN == pMaDN).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public int tinhTongThanhTien(int pMaDN)
        {
            try
            {
                DONNHAP dn = db_LinhKien.DONNHAPs.Select(t => t).Where(t => t.MADN == pMaDN).FirstOrDefault();
                List<CTDONHAP> dsCTDN = new DAL_CTDonNhap().loadCTDonNhapTheMaDN(pMaDN);
                dn.TONGTIEN = dsCTDN.Sum(t => t.THANHTIEN);
                luuDonNhap();
                return int.Parse( dn.TONGTIEN.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
