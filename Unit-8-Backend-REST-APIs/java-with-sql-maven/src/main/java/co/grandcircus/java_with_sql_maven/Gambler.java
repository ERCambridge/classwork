package co.grandcircus.java_with_sql_maven;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;

@Entity
public class Gambler {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)

    private int id;
    private String address;
    private String birth_date;
    private String gambler_name;
    private double monthly_salary;

    public Gambler() {
    }

    public Gambler(int id, String address, String birth_date, String gambler_name, double monthly_salary) {
        this.id = id;
        this.address = address;
        this.birth_date = birth_date;
        this.gambler_name = gambler_name;
        this.monthly_salary = monthly_salary;
    }

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public String getAddress() {
        return address;
    }
    public void setAddress(String address) {
        this.address = address;
    }
    public String getBirth_date() {
        return birth_date;
    }
    public void setBirth_date(String birth_date) {
        this.birth_date = birth_date;
    }
    public String getGambler_name() {
        return gambler_name;
    }
    public void setGambler_name(String gambler_name) {
        this.gambler_name = gambler_name;
    }
    public double getMonthly_salary() {
        return monthly_salary;
    }
    public void setMonthly_salary(double monthly_salary) {
        this.monthly_salary = monthly_salary;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Gambler{");
        sb.append("id=").append(id);
        sb.append(", address=").append(address);
        sb.append(", birth_date=").append(birth_date);
        sb.append(", gambler_name=").append(gambler_name);
        sb.append(", monthly_salary=").append(monthly_salary);
        sb.append('}');
        return sb.toString();
    }

}
