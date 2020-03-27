Module Globale_Variabler
    ''Her skal alle vores værdier stå

#Region "Rasmus værdier"

#End Region

#Region "Daniels værdier"

#End Region

#Region "Troels værdier"
    ''Værdier for Densitet (p = m / V)
    Dim p_Rho As Double 'rho
    Dim m_Masse As Double 'Masse
    Dim V_Rumfang As Double 'Rumfang

    ''Værdier for Gas Densitet (rho = (Molmasse / Gaskonstant) * (tryk / Kelvin))
    Dim m_MolMasse As Double
    Dim T_Kelvin As Double
    Dim R_Gaskonstant As Double


    ''Værdier for Varmekapacitet og Tilføjet varme(C = Q / DT)
    Dim Q_Tilførvarme As Double 'Den tilførte varme
    Dim DT_Temperaturstigning As Double 'Temperaturstigning

    ''Værdier for Specifik Varmekapacitet (c = C / m)
    Dim c_Specifik_Varmekapacitet As Double 'Specifik varmekapacitet
    Dim c_Varmekapacitet As Double 'Varmekapacitet

    ''Værdier for Tryk (p = F / A)
    Dim F_Kraft As Double 'Kraft
    Dim A_Areal As Double 'Areal
    Dim p_Tryk As Double  'Tryk

    ''Værdier for VæskeTryk (p = rho * h * g(9,82))
    Dim h_Højde As Double
    Dim p_VæskeTryk As Double


#End Region


End Module
