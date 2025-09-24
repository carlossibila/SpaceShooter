# 🚀 SpaceShooter - Timeline-Based Shooter

[![Unity](https://img.shields.io/badge/Unity-2022.3+-000.svg?logo=unity)](https://unity.com)

Projeto desenvolvido como follow-along das aulas, implementando um shooter 3D com sistema de timeline para sincronização de eventos de gameplay. O jogo apresenta controle preciso de nave espacial com movimento nos eixos X e Y, sistema de combate com partículas e sincronização audiovisual.

---

## 🎮 Demonstração

![SpaceShooter Gameplay](SpaceShooter/Images/GamePrint.png)


---

## ⚙️ Funcionalidades Técnicas

### **Sistema de Timeline**
- Sincronização de spawn de inimigos com eventos de áudio
- Coordenação de legendas contextuais durante a gameplay

### **Sistema de Controles**
- Movimento suave nos eixos X/Y usando `Mathf.Lerp()` e `Mathf.Clamp()`
- Mira baseada em `RectTransform` com conversão `ScreenToWorldPoint`
- Disparo de lasers com feedback visual imediato

### **Sistema de Partículas**
- Prefabs para efeitos de laser (disparo e impacto)
- Partículas de explosão para destruição de inimigos

### **Gestão de Inimigos**
- Prefabs variants para diferentes tipos de inimigos
- Comportamentos distintos baseados em timelines
- Sistema de wave management integrado com timeline

---

## 🛠️ Stack Tecnológico

### **Programação**
- **C#**: Scripting principal
- **Coroutines**: Para comportamentos temporizados
- **Mathf Library**: Operações matemáticas para movimento e limites

### **Unity Específico**
- **Timeline**: Sincronização de eventos
- **Particle System**: Efeitos visuais
- **RectTransform**: Controle de UI e mira
- **Canvas/UI**: Sistema de interface
- **Prefab System**: Gestão de assets

### **Conceitos Aplicados**
- World Space vs Screen Space coordinates
- Render pipeline básico
- Light and shadow management
- Audio-visual synchronization

---

## 📊 Resultados Alcançados

- ✅ **Sincronização entre timeline e gameplay**  
  Eventos de inimigos, áudio e legendas coordenados com precisão temporal

- ✅ **Sistema de partículas para múltiplos efeitos**  
  Reutilização de prefabs para lasers e explosões com bom desempenho

- ✅ **Controles responsivos com movimento suave**  
  Movimento nos eixos X/Y utilizando `Mathf.Lerp()` e `Mathf.Clamp()`

- ✅ **Prefab system eficiente para variedade de inimigos**  
  Criação de diferentes tipos de inimigos através de variants mantendo organização

- ✅ **HUD funcional com mira precisa em world space**  
  Implementação de targeting usando `RectTransform` e `ScreenToWorldPoint`

---

## 🙏 Créditos

Agradecimento ao professor **Stephen Hubbard** pelas aulas claras e didáticas que permitiram a implementação prática desses conceitos de Unity.




# 🚀 SpaceShooter - Timeline-Based Shooter

Project developed as a follow-along from classes, implementing a 3D shooter with a timeline system for gameplay event synchronization. The game features precise spaceship control with movement on X and Y axes, particle-based combat system, and audiovisual synchronization.

---

## 🎮 Demo

![SpaceShooter Gameplay](SpaceShooter/Images/GamePrint.png)


---

## ⚙️ Technical Features

### **Timeline System**
- Enemy spawn synchronization with audio events
- Contextual caption coordination during gameplay

### **Control System**
- Smooth movement on X/Y axes using `Mathf.Lerp()` and `Mathf.Clamp()`
- Targeting based on `RectTransform` with `ScreenToWorldPoint` conversion
- Laser shooting with immediate visual feedback

### **Particle System**
- Prefabs for laser effects (shooting and impact)
- Explosion particles for enemy destruction

### **Enemy Management**
- Prefab variants for different enemy types
- Distinct behaviors based on timelines
- Wave management system integrated with timeline

---

## 🛠️ Technology Stack

### **Programming**
- **C#**: Main scripting language
- **Coroutines**: For timed behaviors
- **Mathf Library**: Mathematical operations for movement and limits

### **Unity Specific**
- **Timeline**: Event synchronization
- **Particle System**: Visual effects
- **RectTransform**: UI and targeting control
- **Canvas/UI**: Interface system
- **Prefab System**: Asset management

### **Applied Concepts**
- World Space vs Screen Space coordinates
- Basic render pipeline
- Light and shadow management
- Audio-visual synchronization

---

## 📊 Achieved Results

- ✅ **Timeline and gameplay synchronization**  
  Enemy events, audio, and captions coordinated with temporal precision

- ✅ **Particle system for multiple effects**  
  Prefab reuse for lasers and explosions with good performance

- ✅ **Responsive controls with smooth movement**  
  X/Y axis movement using `Mathf.Lerp()` and `Mathf.Clamp()`

- ✅ **Efficient prefab system for enemy variety**  
  Creation of different enemy types through variants while maintaining organization

- ✅ **Functional HUD with precise world space targeting**  
  Targeting implementation using `RectTransform` and `ScreenToWorldPoint`

---

## 🙏 Credits

Special thanks to professor **Stephen Hubbard** for the clear and didactic classes that enabled the practical implementation of these Unity concepts.