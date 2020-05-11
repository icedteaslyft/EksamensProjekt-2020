Module Globale_Variabler
    ''Her skal alle vores værdier stå
    '' Offentlige Booleans
    Public KanRegne As Boolean

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
    Public R_Gaskonstant As Double = 8.3145 'Gaskonstanten er den samme for alle gasser, derfor har vores en allerede givet værdi


    ''Værdier for Varmekapacitet og Tilføjet varme(C = Q / DT)
    Public Q_Tilførtvarme As Double 'Den tilførte varme
    Public Q_Tilførtvarme2 As Double 'Den tilførte varme for Varmekapacitet
    Public DT_Temperaturstigning As Double 'Temperaturstigning
    Public DT_Temperaturstigning2 As Double 'Temperaturstigning for Varmekapacitet

    ''Værdier for Specifik Varmekapacitet (c = C / m)
    Public c_Specifik_Varmekapacitet As Double 'Specifik varmekapacitet
    Public c_Varmekapacitet As Double 'Varmekapacitet
    Public c_Varmekapacitet2 As Double 'Varmekapacitet for Tilført Varme
    Public c_Varmekapacitet3 As Double 'Varmekapacitet for SpecifikVarme


    ''Værdier for Tryk (p = F / A)
    Public F_Kraft As Double 'Kraft
    Public A_Areal As Double 'Areal
    Public p_Tryk As Double  'Tryk


    ''Værdier for VæskeTryk (p = rho * h * g(-9,82))
    Public h_Højde As Double
    Public p_VæskeTryk As Double
    Public g_TyngdeAcceleration As Double

    ''Værdier for Gnidningskraft (F = My * Fn_Normalkraft)
    Public F_Gnidningskraft As Double
    Public My_Gnidningskoefficient As Double
    Public Fn_Normalkraft As Double

    ''Værdier for Idealgas (p * V = n * R * T)
    Public p_Trykket As Double
    Public V_Volumen As Double
    Public n_Stofmængde As Double
    Public T_Temperatur As Double
    Public R_mol As Double
    Public P_V As Double

    ''Værdier for Gravitaion (F = G * m1 * m2/r2)
    Public G_Gravitation As Double
    Public M_Masse1 As Double
    Public M_Masse2 As Double
    Public R_Afstand As Double
    Public F_Resultat As Double

    ''Værdier for Konstruktiv Interferens''
    Public Delta_S As Double
    Public My_M As Double
    Public Delta

    ''Værdier for destruktiv Interferens''


End Module
