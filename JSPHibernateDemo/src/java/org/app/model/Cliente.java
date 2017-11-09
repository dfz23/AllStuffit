/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package org.app.model;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author DFZ-23
 */
@Entity
@Table(name = "cliente")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Cliente.findAll", query = "SELECT c FROM Cliente c")
    , @NamedQuery(name = "Cliente.findByIdcliente", query = "SELECT c FROM Cliente c WHERE c.idcliente = :idcliente")
    , @NamedQuery(name = "Cliente.findByNomcliente", query = "SELECT c FROM Cliente c WHERE c.nomcliente = :nomcliente")
    , @NamedQuery(name = "Cliente.findByTelcliente", query = "SELECT c FROM Cliente c WHERE c.telcliente = :telcliente")
    , @NamedQuery(name = "Cliente.findByDomcliente", query = "SELECT c FROM Cliente c WHERE c.domcliente = :domcliente")})
public class Cliente implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "idcliente")
    private Long idcliente;
    @Basic(optional = false)
    @Column(name = "nomcliente")
    private String nomcliente;
    @Basic(optional = false)
    @Column(name = "telcliente")
    private int telcliente;
    @Basic(optional = false)
    @Column(name = "domcliente")
    private String domcliente;

    public Cliente() {
    }

    public Cliente(Long idcliente) {
        this.idcliente = idcliente;
    }

    public Cliente(Long idcliente, String nomcliente, int telcliente, String domcliente) {
        this.idcliente = idcliente;
        this.nomcliente = nomcliente;
        this.telcliente = telcliente;
        this.domcliente = domcliente;
    }

    public Long getIdcliente() {
        return idcliente;
    }

    public void setIdcliente(Long idcliente) {
        this.idcliente = idcliente;
    }

    public String getNomcliente() {
        return nomcliente;
    }

    public void setNomcliente(String nomcliente) {
        this.nomcliente = nomcliente;
    }

    public int getTelcliente() {
        return telcliente;
    }

    public void setTelcliente(int telcliente) {
        this.telcliente = telcliente;
    }

    public String getDomcliente() {
        return domcliente;
    }

    public void setDomcliente(String domcliente) {
        this.domcliente = domcliente;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idcliente != null ? idcliente.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Cliente)) {
            return false;
        }
        Cliente other = (Cliente) object;
        if ((this.idcliente == null && other.idcliente != null) || (this.idcliente != null && !this.idcliente.equals(other.idcliente))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "org.app.model.Cliente[ idcliente=" + idcliente + " ]";
    }
    
}
