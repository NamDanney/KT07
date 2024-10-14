using De01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace De01
{
    public partial class frmSinhvien : Form
    {

        StudentContextDB db;
        public frmSinhvien()
        {
            InitializeComponent();
            db = new StudentContextDB();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            try {
                List<Sinhvien> listSinhVien = db.Sinhvien.ToList();
                List<Lop> listLop = db.Lop.ToList();
                BindGrid(listSinhVien);
                FillLop(listLop);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BindGrid(List<Sinhvien> listSinhVien)
        {
            DGVSinhVien.Rows.Clear();
            foreach (var item in listSinhVien)
            {
                int index = DGVSinhVien.Rows.Add();
                DGVSinhVien.Rows[index].Cells["Col_MSV"].Value = item.MaSV;
                DGVSinhVien.Rows[index].Cells["Col_HoTen"].Value = item.HotenSV;
                DGVSinhVien.Rows[index].Cells["Col_DATE"].Value = item.NgaySinh;
                DGVSinhVien.Rows[index].Cells["Col_Lop"].Value = item.Lop.TenLop;


            }
        }


        private void FillLop(List<Lop> listLop)
        {
            this.cboLop.DataSource = listLop;
            this.cboLop.DisplayMember = "TenLop";
            this.cboLop.ValueMember = "MaLop";
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DGVSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = DGVSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = selectedRow.Cells[0].Value.ToString();
                txtHoTenSV.Text = selectedRow.Cells[1].Value.ToString();
                dtNgaySinh.Value = (DateTime)selectedRow.Cells[2].Value;
                cboLop.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            List<Sinhvien> listSinhvien = db.Sinhvien.ToList();
            if(listSinhvien.Exists(x => x.MaSV == txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
                return;
            }

            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtHoTenSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(dtNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (txtMaSV.Text.Length != 6)
            {
                MessageBox.Show("Mã sinh viên phải có 6 kí tự và không được chứa ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtHoTenSV.Text.Length > 40 || txtHoTenSV.Text.Any(c => !char.IsLetter(c) && c != ' '))
            {
                MessageBox.Show("Họ tên sinh viên không được quá 40 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newSinhvien = new Sinhvien()
            {
                MaSV = txtMaSV.Text,
                HotenSV = txtHoTenSV.Text,
                NgaySinh = dtNgaySinh.Value,
                MaLop = cboLop.SelectedValue.ToString()
            };
            
            db.Sinhvien.Add(newSinhvien);
            db.SaveChanges();
            BindGrid(db.Sinhvien.ToList());
            MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(txtMaSV.Text))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sv = db.Sinhvien.Find(txtMaSV.Text);
                if (sv == null)
                {
                    MessageBox.Show("Sinh viên không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Bạn có muốn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                db.Sinhvien.Remove(sv);
                db.SaveChanges();
                BindGrid(db.Sinhvien.ToList());
                MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            List<Sinhvien> listSinhvien = db.Sinhvien.ToList();
            var sv = listSinhvien.FirstOrDefault(s => s.MaSV == txtMaSV.Text);
            if (sv != null)
            {
                if (listSinhvien.Any(s => s.MaSV == txtMaSV.Text && s.MaSV != sv.MaSV))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã số khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtHoTenSV.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (dtNgaySinh.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sv.HotenSV = txtHoTenSV.Text;
                sv.MaLop = cboLop.SelectedValue.ToString();
                sv.NgaySinh = dtNgaySinh.Value;
                db.SaveChanges();
                BindGrid(db.Sinhvien.ToList());
                MessageBox.Show("Sửa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = txtTim.Text.Trim();
                if (string.IsNullOrEmpty(searchName))
                {
                    MessageBox.Show("Vui lòng nhập tên sinh viên để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<Sinhvien> searchResults = db.Sinhvien.Where(sv => sv.HotenSV.Contains(searchName)).ToList();
                if (searchResults.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BindGrid(searchResults);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                BindGrid(db.Sinhvien.ToList());
            }
        }
    }
}
