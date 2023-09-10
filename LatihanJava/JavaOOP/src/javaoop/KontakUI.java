
package javaoop;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;

public class KontakUI extends JFrame {
    private ArrayList<Kontak> kontak = new ArrayList<Kontak>();

    private JList<String> daftarKontak;
    private DefaultListModel<String> modelKontak;

    private JButton tambahBtn;
    private JButton hapusBtn;
    private JButton ubahBtn;
    private JButton keluarBtn;

    private JTextField namaField;
    private JTextField nomorField;
    private JTextField emailField;

    private final JLabel namaLabel;
    private final JLabel nomorLabel;
    private final JLabel emailLabel;

    public KontakUI() {
        super("Buku Kontak");

        // Inisialisasi komponen
        modelKontak = new DefaultListModel<String>();
        daftarKontak = new JList<String>(modelKontak);

        tambahBtn = new JButton("Tambah");
        hapusBtn = new JButton("Hapus");
        ubahBtn = new JButton("Ubah");
        keluarBtn = new JButton("Keluar");

        namaField = new JTextField(20);
        nomorField = new JTextField(20);
        emailField = new JTextField(20);

        namaLabel = new JLabel("Nama:");
        nomorLabel = new JLabel("Nomor Telepon:");
        emailLabel = new JLabel("Email:");

        // Set layout
        setLayout(new BorderLayout());

        JPanel kontakPanel = new JPanel(new BorderLayout());
        kontakPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        // Tambahkan daftar kontak
        kontakPanel.add(new JScrollPane(daftarKontak), BorderLayout.CENTER);

        // Tambahkan tombol-tombol
        JPanel tombolPanel = new JPanel(new GridLayout(4, 1, 10, 10));
        tombolPanel.add(tambahBtn);
        tombolPanel.add(hapusBtn);
        tombolPanel.add(ubahBtn);
        tombolPanel.add(keluarBtn);
        kontakPanel.add(tombolPanel, BorderLayout.EAST);

        // Tambahkan form untuk input kontak baru
        JPanel inputPanel = new JPanel(new GridLayout(3, 2, 10, 10));
        inputPanel.add(namaLabel);
        inputPanel.add(namaField);
        inputPanel.add(nomorLabel);
        inputPanel.add(nomorField);
        inputPanel.add(emailLabel);
        inputPanel.add(emailField);

        // Tambahkan panel-panel ke frame
        add(kontakPanel, BorderLayout.CENTER);
        add(inputPanel, BorderLayout.SOUTH);

        // Tambahkan event listener
        tambahBtn.addActionListener(e -> tambahKontak());
        hapusBtn.addActionListener(e -> hapusKontak());
        ubahBtn.addActionListener(e -> ubahKontak());
        keluarBtn.addActionListener(e -> System.exit(0));

        // Atur frame
        setSize(500, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
    }

    public void tambahKontak() {
        String nama = namaField.getText();
        String nomor = nomorField.getText();
        String email = emailField.getText();

        if (nama.isEmpty() || nomor.isEmpty() || email.isEmpty()) {
            JOptionPane.showMessageDialog(this, "Silakan isi semua kolom!");
            return;
        }

        Kontak kontakBaru = new Kontak(nama, nomor, email);
        kontak.add(kontakBaru);
        modelKontak.addElement(kontakBaru.getNama());
JOptionPane.showMessageDialog(this, "Kontak berhasil ditambahkan!");
}

public void hapusKontak() {
    int index = daftarKontak.getSelectedIndex();
    if (index == -1) {
        JOptionPane.showMessageDialog(this, "Silakan pilih kontak yang akan dihapus!");
        return;
    }

    String nama = modelKontak.getElementAt(index);
    int confirm = JOptionPane.showConfirmDialog(this, "Anda yakin ingin menghapus kontak " + nama + "?");
    if (confirm == JOptionPane.YES_OPTION) {
        kontak.remove(index);
        modelKontak.removeElementAt(index);
        JOptionPane.showMessageDialog(this, "Kontak berhasil dihapus!");
    }
}

public void ubahKontak() {
    int index = daftarKontak.getSelectedIndex();
    if (index == -1) {
        JOptionPane.showMessageDialog(this, "Silakan pilih kontak yang akan diubah!");
        return;
    }

    String nama = modelKontak.getElementAt(index);
    String nomor = JOptionPane.showInputDialog(this, "Masukkan nomor telepon baru untuk " + nama + ":");
    String email = JOptionPane.showInputDialog(this, "Masukkan email baru untuk " + nama + ":");

    if (nomor.isEmpty() || email.isEmpty()) {
        JOptionPane.showMessageDialog(this, "Silakan isi semua kolom!");
        return;
    }

    Kontak kontakBaru = new Kontak(nama, nomor, email);
    kontak.set(index, kontakBaru);
    modelKontak.setElementAt(kontakBaru.getNama(), index);
    JOptionPane.showMessageDialog(this, "Kontak berhasil diubah!");
}

public static void main(String[] args) {
    new KontakUI();
}
}

class Kontak {
private String nama;
private String nomor;
private String email;

public Kontak(String nama, String nomor, String email) {
    this.nama = nama;
    this.nomor = nomor;
    this.email = email;
}

public String getNama() {
    return nama;
}

public void setNama(String nama) {
    this.nama = nama;
}

public String getNomor() {
    return nomor;
}

public void setNomor(String nomor) {
    this.nomor = nomor;
}

public String getEmail() {
    return email;
}

public void setEmail(String email) {
    this.email = email;
}

}