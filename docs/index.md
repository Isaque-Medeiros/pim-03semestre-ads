---
title: "BSFM - Initial"
date: "2026"
layout: default
hide:
  - navigation
  - toc
---

<style>
  /* 1. CORREÇÃO DO LAYOUT GLOBAL */
  body {
    background-color: #0d1117; /* Preto Profundo */
    color: #c9d1d9; /* Cinza claro para leitura */
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Helvetica, Arial, sans-serif;
    margin: 0;
    padding: 0;
  }

  /* Reset de margens do tema Material */
  .md-main__inner { max-width: none !important; margin-top: 0 !important; padding: 0 !important; }
  .md-content { margin-left: 0 !important; }
  .md-content__inner { margin: 0 !important; padding: 0 !important; }
  .md-footer { display: none; }

  /* 2. SEUS ESTILOS PERSONALIZADOS */
  .container {
    width: 100%;
    max-width: 1200px;
    padding: 0 20px;
    box-sizing: border-box;
    margin: 0 auto;
  }

  .hero {
    text-align: center;
    padding: 80px 0 60px 0;
    background-image: radial-gradient(#40E0D0 0.5px, transparent 0.5px); /* Pontos Turquesa */
    background-size: 20px 20px;
    background-color: #0d1117;
    width: 100%;
  }

  h1 { font-size: 40px; margin-bottom: 30px; font-weight: 600; color: #fff; }

  .search-box {
    background: #161b22;
    border: 1px solid #40E0D0; /* Borda Turquesa */
    border-radius: 12px;
    padding: 12px 20px;
    max-width: 700px;
    margin: 0 auto;
    display: flex;
    align-items: center;
    justify-content: space-between;
    transition: box-shadow 0.3s;
    box-shadow: 0 0 10px rgba(64, 224, 208, 0.1);
  }

  .search-inner { display: flex; align-items: center; gap: 12px; }

  .ai-icon {
    background: linear-gradient(135deg, #40E0D0, #008B8B); /* Gradiente Turquesa */
    border-radius: 6px;
    padding: 4px;
    display: flex;
  }

  .placeholder { color: #40E0D0; font-size: 16px; opacity: 0.6; }

  .tags-container {
    margin-top: 30px;
    display: flex;
    justify-content: center;
    gap: 10px;
    flex-wrap: wrap;
    max-width: 800px;
    margin-left: auto;
    margin-right: auto;
  }

  .tag {
    background: #161b22;
    border: 1px solid #30363d;
    padding: 8px 16px;
    border-radius: 20px;
    font-size: 13px;
    color: #40E0D0; /* Texto Turquesa */
    cursor: pointer;
    transition: background 0.2s;
  }
  .tag:hover { background: rgba(64, 224, 208, 0.1); border-color: #40E0D0; }

  .grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 20px;
    margin: 40px 0;
  }

  .card {
    background: #161b22;
    border: 1px solid #30363d;
    border-radius: 12px;
    padding: 20px;
    display: flex;
    gap: 20px;
    align-items: flex-start;
    transition: border 0.3s;
  }
  .card:hover { border-color: #40E0D0; }

  .card-icon {
    background: #21262d;
    padding: 8px;
    border-radius: 6px;
    color: #40E0D0; /* Ícone Turquesa */
  }

  .card-content h3 { margin: 0 0 5px 0; font-size: 16px; color: #40E0D0; } /* Título Turquesa */
  .card-content p { margin: 0; font-size: 13px; color: #8b949e; line-height: 1.4; }

  .featured-section { margin-top: 40px; text-align: center; }

  .featured-list {
    background: #161b22;
    border: 1px solid #30363d;
    border-radius: 12px;
    max-width: 800px;
    margin: 20px auto;
    text-align: left;
  }

  .list-item {
    padding: 16px 20px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    border-bottom: 1px solid #30363d;
  }

  footer {
    width: 100%;
    border-top: 1px solid #40E0D0; /* Linha Turquesa no Footer */
    padding: 40px 0;
    margin-top: 80px;
    background: #0c1117;
  }

  .footer-content {
    display: flex;
    justify-content: space-between;
    align-items: center;
    color: #40E0D0;
    font-size: 14px;
    flex-wrap: wrap;
    gap: 20px;
  }

  .footer-links { display: flex; gap: 20px; align-items: center; flex-wrap: wrap; }
  .copyright { margin-top: 20px; color: #484f58; font-size: 12px; text-align: center;}
  
  .digite { display: flex; align-items: center; gap: 8px; font-size: 14px; color: #40E0D0; }
</style>
<!-- Hero - Ocupará toda a largura -->
<div class="hero">
  <h1>Como podemos te ajudar?</h1>
  <div class="search-box">
    <div class="search-inner">
      <div class="ai-icon">
        <svg width="20" height="20" viewBox="0 0 24 24" fill="white"><path d="M12,2L14.85,8.15L21,11L14.85,13.85L12,20L9.15,13.85L3,11L9.15,8.15L12,2M12,17.27L13.1,14.9L15.47,13.8L13.1,12.7L12,10.33L10.9,12.7L8.53,13.8L10.9,14.9L12,17.27Z" /></svg>
      </div>
      <span class="placeholder"><b>Busque por qualquer informação...</b></span>
    </div>
    <div class="digite">
      <svg width="20" height="20" viewBox="0 0 24 24" fill="#8b949e"><path d="M4,11V13H16L10.5,18.5L11.92,19.92L19.84,12L11.92,4.08L10.5,5.5L16,11H4Z" /></svg>
      <p>Digite alguma coisa..."</p>
    </div>
  </div>
  <div class="tags-container">
    <div class="tag">Quais dispositivos são compatíveis?</div>
    <div class="tag">Planos e benefícios.</div>
    <div class="tag">Problema no login.</div>
  </div>
</div>

<div class="container">
  <!-- Categories -->
  <div class="grid">
      <div class="card"><a href="config/">
        <div class="card-icon"><svg width="24" height="24" viewBox="0 0 24 24" fill="#3b82f6"><path d="M12,16A3,3 0 0,1 9,13C9,11.88 9.61,10.9 10.5,10.39L20.21,4.77L14.68,14.35C14.18,15.33 13.17,16 12,16M12,2A10,10 0 0,0 2,12A10,10 0 0,0 12,22A10,10 0 0,0 22,12A10,10 0 0,0 12,2M12,4A8,8 0 0,1 20,12A8,8 0 0,1 12,20A8,8 0 0,1 4,12A8,8 0 0,1 12,4Z"/></svg></div></a>
        <div class="card-content">
          <h3>Get started</h3>
          <p>Aprenda como o aplicativo funciona.</p>
        </div>
      </div>
      <div class="card"><a href="config/">
        <div class="card-icon"><svg width="24" height="24" viewBox="0 0 24 24" fill="#3b82f6"><path d="M18.65,2.85L19.26,6.71L22.77,8.23L21,11.5L22.77,14.77L19.26,16.29L18.65,20.15L14.79,19.54L13.27,23.05L10,21.28L6.73,23.05L5.21,19.54L1.35,20.15L1.96,16.29L-1.55,14.77L0.22,11.5L-1.55,8.23L1.96,6.71L1.35,2.85L5.21,3.46L6.73,-0.05L10,1.72L13.27,-0.05L14.79,3.46L18.65,2.85M12,7A5,5 0 0,0 7,12A5,5 0 0,0 12,17A5,5 0 0,0 17,12A5,5 0 0,0 12,7Z"/></svg></div></a>
        <div class="card-content">
          <h3>Guias</h3>
          <p>Veja todos os guias.</p>
        </div>
      </div>
      <div class="card"><a href="config/">
        <div class="card-icon"><svg width="24" height="24" viewBox="0 0 24 24" fill="#3b82f6"><path d="M14,2H6A2,2 0 0,0 4,4V20A2,2 0 0,0 6,22H18A2,2 0 0,0 20,20V8L14,2M13,9V3.5L18.5,9H13Z"/></svg></div></a>
        <div class="card-content">
          <h3>Menus</h3>
          <p>Todos os menus disponíveis.</p>
        </div>
      </div>
      <div class="card"><a href="config/">
        <div class="card-icon"><svg width="24" height="24" viewBox="0 0 24 24" fill="#3b82f6"><path d="M12.89,3L14.85,3.4L11.11,21L9.15,20.6L12.89,3M19.59,12L16,8.41V5.58L22.42,12L16,18.41V15.58L19.59,12M1.58,12L8,5.58V8.41L4.41,12L8,15.58V18.41L1.58,12Z"/></svg></div></a>
        <div class="card-content">
          <h3>Referência</h3>
          <p>Consulte referências de dev.</p>
        </div>
      </div>
  </div>

  <div class="featured-section">
    <h2>Tópicos frequentes</h2>
    <div class="featured-list">
      <div class="list-item">Em breve...</div>
    </div>
  </div>

  <!-- Footer Interno -->
  <footer>
    <div class="footer-content">
      <div class="footer-links">
        <span>Offerings</span>
        <span>Pricing</span>
        <span>About us</span>
      </div>
      <div class="footer-links">
        <span>Privacy</span> | <span>Terms</span> | <span>Status</span>
      </div>
    </div>
    <div class="copyright">Copyright © 2026-2036 Brazilian System of Food Metric | BSFM</div>
  </footer>
</div>