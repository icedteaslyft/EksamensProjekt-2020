Module Globale_Variabler
    ''Her skal alle vores værdier stå


    'Værdier for Elektrisk Ladning (Q = I * t)
    Public Q_ElektriskLadning As Double 'Elektrisk Ladning
    Public t_DeltaTid As Double 'Delta tid
    Public I_Strømstyrke As Double 'Strømstyrke


    ''Værdier for Densitet (p = m / V)
    Public p_Rho As Double 'rho
    Public m_Masse As Double 'Masse
    Public V_Rumfang As Double 'Rumfang


    ''Værdier for Gas Densitet (rho = (Molmasse / Gaskonstant) * (tryk / Kelvin))
    Public m_MolMasse As Double
    Public T_Kelvin As Double
    Public R_Gaskonstant As Double = 8.3145


    ''Værdier for Varmekapacitet og Tilføjet varme(C = Q / DT)
    Public Q_Tilførtvarme As Double 'Den tilførte varme
    Public DT_Temperaturstigning As Double 'Temperaturstigning


    ''Værdier for Specifik Varmekapacitet (c = C / m)
    Public c_Specifik_Varmekapacitet As Double 'Specifik varmekapacitet
    Public c_Varmekapacitet As Double 'Varmekapacitet


    ''Værdier for Tryk (p = F / A)
    Public F_Kraft As Double 'Kraft
    Public A_Areal As Double 'Areal
    Public p_Tryk As Double  'Tryk


    ''Værdier for VæskeTryk (p = rho * h * g(9,82))
    Public h_Højde As Double
    Public p_VæskeTryk As Double
    Public g_TyngdeAcceleration As Double


End Module
