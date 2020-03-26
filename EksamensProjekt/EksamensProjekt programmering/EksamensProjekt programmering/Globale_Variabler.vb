Module Globale_Variabler
    ''Her skal alle vores værdier stå

#Region "Rasmus værdier"

#End Region

#Region "Daniels værdier"

#End Region

#Region "Troels værdier"
    ''Værdier for Densitet (p = m / V)
    Dim p_Rho As Decimal 'rho
    Dim m_Masse As Decimal 'Masse
    Dim V_Rumfang As Decimal 'Rumfang

    ''Værdier for Gas Densitet (rho = (Molmasse / Gaskonstant) * (tryk / Kelvin))
    Dim m_MolMasse As Decimal
    Dim T_Kelvin As Decimal
    Dim R_Gaskonstant As Decimal


    ''Værdier for Varmekapacitet og Tilføjet varme(C = Q / DT)
    Dim Q_Tilførvarme As Decimal 'Den tilførte varme
    Dim DT_Temperaturstigning As Decimal 'Temperaturstigning

    ''Værdier for Specifik Varmekapacitet (c = C / m)
    Dim c_Specifik_Varmekapacitet As Decimal 'Specifik varmekapacitet
    Dim c_Varmekapacitet As Decimal 'Varmekapacitet

    ''Værdier for Tryk (p = F / A)
    Dim F_Kraft As Decimal 'Kraft
    Dim A_Areal As Decimal 'Areal
    Dim p_Tryk As Decimal  'Tryk

    ''Værdier for VæskeTryk (p = rho * h * g(9,82))
    Dim h_Højde As Decimal
    Dim p_VæskeTryk As Decimal


#End Region


End Module
