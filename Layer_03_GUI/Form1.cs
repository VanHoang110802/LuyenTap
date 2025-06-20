using Layer_01_DAL.Folder_01_Entities;
using Layer_02_BLL.Folder_02_Services;

namespace Layer_03_GUI
{
    public partial class Form1 : Form
    {
        private XuLySanPhamService_bll _xuLySanPham;
        private XuLyHangService_bll _xuLyHang;
        public Form1()
        {
            InitializeComponent();
            _xuLySanPham = new XuLySanPhamService_bll();
            _xuLyHang = new XuLyHangService_bll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTextComboBox();
            LoadingData();
        }

        void LoadTextComboBox()
        {
            var dsHang = _xuLyHang.DocLayToanBoHang_Bll();
            cbb_sp_HangSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_sp_HangSP.DataSource = dsHang;
            cbb_sp_HangSP.DisplayMember = "TenHang";
            cbb_sp_HangSP.ValueMember = "MaHang";
        }

        void LoadingData()
        {
            var listSanPhamWithHang = _xuLySanPham.DocLaySanPhamWithHang_Bll();
            dgv_sp_ThongTin.DataSource = null; // reset trước
            dgv_sp_ThongTin.DataSource = listSanPhamWithHang;

            dgv_sp_ThongTin.ReadOnly = true;
            dgv_sp_ThongTin.AllowUserToAddRows = false;
            dgv_sp_ThongTin.AllowUserToDeleteRows = false;

            txt_sp_TenSP.Text = "";
            txt_sp_GiaSP.Text = "";
            txt_sp_TKSP.Text = "";

            dgv_sp_ThongTin.Columns["MaHang"].Visible = false;
            rb_sp_CTT.Checked = true;
        }

        private void btn_sp_Them_Click(object sender, EventArgs e)
        {
            string tenSp = txt_sp_TenSP.Text.Trim();
            float gia = float.Parse(txt_sp_GiaSP.Text.Trim());
            int maHang = (int)cbb_sp_HangSP.SelectedValue;

            SanPham_dal sp = new SanPham_dal()
            {
                TenSP = tenSp,
                Gia = gia,
                MaHang = maHang
            };

            bool ketQua = _xuLySanPham.TaoThemSanPham_Bll(sp);
            if (ketQua)
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadingData();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
        }

        private void btn_sp_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_sp_ThongTin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            foreach (DataGridViewRow row in dgv_sp_ThongTin.SelectedRows)
            {
                int maSP = (int)row.Cells["MaSP"].Value;
                _xuLySanPham.XoaSanPham_Bll(maSP);
            }

            MessageBox.Show("Đã xóa thành công!");
            LoadingData();
        }

        private void dgv_sp_ThongTin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_sp_ThongTin.SelectedRows.Count > 0)
            {
                var chonDong = dgv_sp_ThongTin.SelectedRows[0];
                //txt_sp_MaSP.Text = row.Cells["MaSP"].Value.ToString();
                txt_sp_TenSP.Text = chonDong.Cells["TenSP"].Value.ToString();
                txt_sp_GiaSP.Text = chonDong.Cells["Gia"].Value.ToString();
                cbb_sp_HangSP.SelectedValue = chonDong.Cells["MaHang"].Value;
               
                // Cập nhật trạng thái TinhTrang vào RadioButton
                bool tinhTrang = (bool)chonDong.Cells["TinhTrang"].Value;

                if (tinhTrang)
                {
                    rb_sp_CTT.Checked = false;
                    rb_sp_DTT.Checked = true;
                }
                else
                {
                    rb_sp_CTT.Checked = true;
                    rb_sp_DTT.Checked = false;
                }
            }
            else
            {
                txt_sp_TenSP.Text = "";
                txt_sp_GiaSP.Text = "";
                cbb_sp_HangSP.SelectedValue = 1;
                rb_sp_CTT.Checked = true;
            }
        }

        private void btn_sp_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_sp_ThongTin.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chọn sản phẩm để sửa");

            }
            else
            {
                var row = dgv_sp_ThongTin.SelectedRows[0];
                var sanPham = new SanPham_dal()
                {
                    MaSP = (int)row.Cells["MaSP"].Value,
                    TenSP = row.Cells["TenSP"].Value.ToString(),
                    Gia = Convert.ToSingle(row.Cells["Gia"].Value),
                    MaHang = (int)row.Cells["MaHang"].Value,
                    TinhTrang = (bool)row.Cells["TinhTrang"].Value
                };



                sanPham.TenSP = txt_sp_TenSP.Text.Trim();
                sanPham.Gia = float.Parse(txt_sp_GiaSP.Text.Trim());
                sanPham.MaHang = (int)cbb_sp_HangSP.SelectedValue;
                sanPham.TinhTrang = (bool)rb_sp_CTT.Checked ? true : false;

                bool kq = _xuLySanPham.CapNhatSanPham_Bll(sanPham);
                if (kq)
                {
                    MessageBox.Show("Đã cập nhật.");
                    LoadingData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }

            }
        }

        private void btn_sp_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_sp_TKSP.Text.Trim();

            var list = _xuLySanPham.TimKiemSanPhamBll(keyword);

            // Gán lại dữ liệu vào GridView
            dgv_sp_ThongTin.DataSource = list.Select(sp => new
            {
                sp.MaSP,
                sp.TenSP,
                sp.Gia,
                TenHang = sp.hang_dal.TenHang
            }).ToList();
        }

        private void btn_sp_ThoatTK_Click(object sender, EventArgs e)
        {
            LoadingData();
        }
    }
}
