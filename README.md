# SmartMed Pharmacy Management System

### Software Engineering Case Study  
**Requirements Engineering • Business Analysis • Solution Design • Object-Oriented Development**

---

> A desktop-based Pharmacy Management System designed through a structured Business Analysis approach to improve pharmacy operations by standardising business processes, strengthening data integrity, and supporting operational decision-making. The project demonstrates the complete Software Development Life Cycle (SDLC), from requirements elicitation and process analysis through solution design, implementation, testing, and technical documentation.

---

## Project Overview

SmartMed is a desktop-based Pharmacy Management System developed to address common operational challenges encountered in small and medium-sized pharmacy environments. The solution provides a centralised platform for medicine inventory management, customer administration, prescription handling, order processing, operational reporting, and administrative monitoring.

Rather than approaching the project solely as a software implementation exercise, the solution was developed by following a structured Software Development Life Cycle in which Business Analysis established the foundation for all subsequent design and development activities. Business requirements were analysed, validated, modelled, and translated into a solution architecture that maintained traceability between stakeholder expectations, business rules, system behaviour, and implementation.

The completed solution demonstrates how disciplined requirements engineering and structured solution design contribute to delivering software that addresses operational needs while maintaining maintainability, consistency, and scalability.

---

## Business Context

Pharmacy operations depend upon accurate inventory control, efficient customer management, prescription validation, order processing, and timely access to operational information. Organisations relying on fragmented or manually coordinated processes frequently experience inconsistent data, duplicated effort, reduced process visibility, and increased administrative overhead.

The objective of SmartMed was not simply to digitise existing activities, but to analyse operational workflows, identify process inefficiencies, define measurable business requirements, and design a solution capable of supporting consistent operational execution while enforcing business policies throughout the application.

The project therefore focused equally on business process improvement and technical implementation, ensuring that every functional capability could be traced back to an identified business need.

---

## Project Objectives

The project was undertaken to achieve the following business objectives:

- Standardise pharmacy operational workflows through a single integrated desktop solution.
- Improve inventory accuracy through controlled medicine lifecycle management.
- Strengthen customer record management while reducing duplicate data.
- Support compliant prescription handling through defined validation rules.
- Improve order processing efficiency through structured workflow management.
- Provide administrators with real-time operational visibility using dashboard metrics and reporting.
- Maintain consistency between documented business requirements, solution architecture, database design, and implemented functionality.
- Demonstrate the practical application of Business Analysis, Requirements Engineering, Object-Oriented Design, and Software Engineering principles throughout the Software Development Life Cycle.

---

## My Role

This project was completed as an end-to-end Software Engineering case study in which Business Analysis informed every stage of solution development.

My responsibilities included:

- Business problem analysis
- Stakeholder identification and analysis
- Requirements elicitation and documentation
- Functional and non-functional requirement specification
- Business rule definition
- Business process analysis
- UML modelling and system specification
- Solution architecture design
- Entity relationship modelling
- Object-oriented solution design
- Desktop application development using C# (.NET Framework)
- SQLite database design and implementation
- Solution verification and validation
- Technical documentation and implementation reporting

The implementation was continuously validated against the documented requirements baseline to ensure alignment between business objectives, analytical artefacts, and delivered functionality.

---

## Business Analysis Approach

The project adopted a structured Business Analysis approach before any implementation activities commenced.

Rather than treating the provided scenario as a complete specification, the analysis phase focused on understanding the operational environment, identifying business events, analysing stakeholder responsibilities, documenting business constraints, defining system boundaries, and establishing a complete requirements baseline.

Requirements were progressively refined through business process analysis, ensuring that each functional capability addressed a genuine operational need and that supporting business rules were explicitly documented prior to solution design.

This analytical foundation informed the development of the solution architecture, database model, object-oriented design, and user workflows, enabling traceability between business requirements, design artefacts, implementation decisions, and system behaviour throughout the Software Development Life Cycle.



---

# Stakeholder Analysis

Stakeholder Analysis was conducted to establish a comprehensive understanding of the operational environment before defining the solution scope. Rather than viewing the requested system as a predefined software application, the analysis focused on identifying organisational objectives, operational responsibilities, information requirements, process dependencies, and stakeholder expectations that collectively influence pharmacy operations.

This analytical approach ensured that the proposed solution addressed genuine business needs rather than implementing isolated software features. Each stakeholder was analysed in terms of their responsibilities, interactions with the system, operational challenges, business objectives, decision-making requirements, and expected business outcomes. The resulting stakeholder model provided the foundation for requirements elicitation, business process modelling, functional decomposition, and solution architecture.

By establishing stakeholder alignment during the early stages of the Software Development Life Cycle, the project maintained consistency between business objectives, documented requirements, system behaviour, and implemented functionality.

---

## Stakeholder Identification

The stakeholder landscape was categorised into primary and secondary stakeholder groups based on their operational responsibilities, level of system interaction, and influence on business outcomes.

### Primary Stakeholders

Primary stakeholders directly interact with the application to perform business-critical operational activities.

| Stakeholder | Primary Business Objective | Business Value Delivered |
|-------------|---------------------------|--------------------------|
| **Pharmacy Administrator** | Manage daily pharmacy operations through a single integrated platform. | Operational efficiency, inventory visibility, business control and reporting. |
| **Customer** | Purchase medicines through a structured and user-friendly workflow. | Improved customer experience, simplified ordering process and secure account management. |

---

### Pharmacy Administrator

The Pharmacy Administrator represents the principal operational stakeholder responsible for overseeing day-to-day business activities. This role performs administrative, operational and supervisory responsibilities that directly influence pharmacy performance.

Key operational responsibilities include:

- Managing medicine inventory throughout its lifecycle.
- Maintaining customer information.
- Processing customer orders.
- Monitoring prescription submissions.
- Managing promotional offers.
- Producing operational reports.
- Monitoring business performance through management dashboards.
- Maintaining data quality across business records.

The analysis identified several operational challenges commonly associated with manual or fragmented pharmacy workflows, including duplicated administrative effort, inconsistent inventory records, delayed reporting, and reduced operational visibility.

Consequently, the proposed solution was designed to support structured business processes, improve data accuracy, strengthen process control, and provide timely operational insight for informed decision-making.

---

### Customer

Customers represent the primary external stakeholder consuming pharmacy services.

The analysis focused on understanding the complete customer journey, beginning with account registration and continuing through medicine discovery, prescription submission, purchasing activities, and order completion.

Business expectations identified during analysis included:

- Secure authentication.
- Intuitive account management.
- Efficient medicine search.
- Transparent ordering process.
- Prescription submission for regulated medicines.
- Order status visibility.
- Reliable transaction processing.

The customer-facing functionality was therefore designed to minimise process complexity while ensuring compliance with organisational policies governing prescription-controlled medicines.

---

### Secondary Stakeholders

Although the application is primarily designed around pharmacy operations, several indirect stakeholder groups influence business requirements and system behaviour.

These include:

- Pharmacy business owners responsible for organisational performance.
- Future administrative personnel responsible for maintaining operational continuity.
- System maintainers responsible for ongoing enhancement and corrective maintenance.
- Academic evaluators responsible for validating software engineering practices.

Recognising these stakeholders during analysis contributed towards improved maintainability, structured documentation, architectural consistency and future extensibility.

---

## Stakeholder Expectations

Stakeholder expectations were translated into measurable business outcomes rather than isolated software features.

Key stakeholder expectations included:

- Improved operational efficiency.
- Accurate inventory management.
- Reliable customer information.
- Controlled prescription processing.
- Faster order fulfilment.
- Consistent application behaviour.
- Secure data management.
- Reduced manual administrative effort.
- Improved reporting capability.
- Better operational visibility.

These expectations subsequently informed functional requirements, business rules, quality attributes, system architecture and verification activities throughout the project lifecycle.

---

## Stakeholder Value Alignment

Maintaining alignment between stakeholder objectives and implemented functionality formed a central principle throughout the project.

Each functional capability implemented within the application can be traced to one or more documented stakeholder needs, ensuring that development effort remained focused on delivering measurable business value rather than unnecessary technical complexity.

This stakeholder-centred approach established traceability between:

- Business objectives
- Stakeholder expectations
- Business requirements
- Functional capabilities
- System architecture
- Database design
- Application modules
- Test scenarios

This alignment significantly reduced ambiguity during implementation while supporting solution consistency across analytical artefacts, technical design and delivered functionality.

---

# Requirements Engineering

Requirements Engineering was treated as a continuous analytical discipline throughout the Software Development Life Cycle rather than a single documentation activity.

Instead of interpreting the case study as a fixed software specification, the analysis process focused on progressively understanding organisational objectives, operational workflows, stakeholder expectations, business events, information flows, constraints, and process dependencies. This enabled requirements to evolve through structured analysis before being translated into technical solution components.

The resulting requirements baseline became the authoritative reference for subsequent architecture design, UML modelling, database modelling, implementation, testing and solution validation.

Maintaining this baseline ensured that every implemented capability remained traceable to an identified business need.

---

## Requirements Discovery and Elicitation

The discovery process focused on identifying explicit and implicit business needs by analysing the operational environment rather than immediately defining software functionality.

Requirements were elicited through systematic examination of:

- Business objectives.
- Operational workflows.
- Stakeholder responsibilities.
- Business events.
- Existing process limitations.
- Organisational policies.
- Information management requirements.
- Regulatory considerations relating to prescription handling.

This approach enabled the project to distinguish genuine business requirements from implementation preferences while ensuring that solution scope remained aligned with organisational objectives.

The elicitation process also identified several implicit operational needs that were not directly stated within the original business scenario but were essential for successful system implementation. These derived requirements were subsequently validated before inclusion within the solution scope.

---

## Requirements Classification

To improve analytical clarity and support end-to-end traceability, identified requirements were categorised into distinct requirement groups according to their purpose, implementation impact and business significance.

The project requirements were classified as follows:

- Business Requirements
- Functional Requirements
- Non-Functional Requirements
- Technical Requirements
- Hardware Requirements
- Software Requirements
- Business Rules
- Derived Requirements
- Assumptions
- Constraints

Separating requirements into clearly defined categories simplified impact analysis, reduced ambiguity during implementation, and strengthened consistency between analytical documentation, solution architecture and software development activities.

---

## Business Requirements

Business Requirements define the organisational objectives that justified the development of the SmartMed Pharmacy Management System. Unlike functional requirements, which describe specific system capabilities, business requirements establish the measurable outcomes that the organisation expects the solution to achieve.

The analysis identified the following business requirements:

### BR-01 — Improve Operational Efficiency

Provide an integrated platform capable of reducing fragmented workflows and eliminating unnecessary manual administrative activities across daily pharmacy operations.

### BR-02 — Strengthen Inventory Visibility

Enable accurate monitoring of medicine availability through structured inventory management, supporting informed replenishment decisions while reducing stock inconsistencies.

### BR-03 — Improve Customer Information Management

Maintain accurate and centrally managed customer records that support efficient service delivery, minimise duplicate information and improve data consistency.

### BR-04 — Streamline Order Processing

Provide a structured order management workflow that supports efficient transaction processing while maintaining operational control throughout the order lifecycle.

### BR-05 — Support Prescription Governance

Implement controlled prescription management processes that ensure regulated medicines are processed according to defined organisational policies.

### BR-06 — Improve Operational Reporting

Provide timely access to business information through reporting and dashboard capabilities that support operational monitoring and management decision-making.

### BR-07 — Maintain Data Integrity

Ensure that business information remains accurate, consistent and protected throughout all operational processes by enforcing validation rules and controlled data management practices.

### BR-08 — Support Long-Term Maintainability

Adopt a structured solution architecture that facilitates future enhancement, corrective maintenance and continued business growth while maintaining consistency between documented requirements and implemented functionality.

---

## Functional Requirements

Functional Requirements describe the specific business capabilities required to satisfy the documented business objectives. Each functional requirement represents a measurable business service that supports one or more operational processes identified during analysis.

Rather than implementing isolated software screens, functional capabilities were derived directly from analysed business workflows to ensure complete alignment between operational requirements and delivered functionality.

The functional requirements baseline included the following core capability domains:

| Functional Domain | Business Purpose |
|-------------------|------------------|
| Authentication & User Management | Establish secure user access and protect business information. |
| Medicine Inventory Management | Support complete medicine lifecycle management while maintaining inventory accuracy. |
| Customer Management | Maintain structured customer records to support service delivery. |
| Medicine Search & Product Discovery | Enable efficient identification of medicines through searchable inventory information. |
| Prescription Management | Facilitate controlled processing of prescription-based medicines in accordance with business policies. |
| Shopping Cart & Order Processing | Support structured purchasing workflows from medicine selection through transaction completion. |
| Dashboard & Operational Analytics | Provide management visibility through real-time operational metrics. |
| Reporting | Generate structured business reports that support operational monitoring and decision-making. |
| Promotion & Discount Management | Support controlled promotional activities while maintaining pricing consistency. |

Each functional capability was subsequently modelled through UML artefacts, mapped to database entities, implemented using an object-oriented architecture, and validated through functional testing to maintain complete traceability across the Software Development Life Cycle.

---

---

## Non-Functional Requirements

While Functional Requirements define **what** the solution must accomplish, Non-Functional Requirements establish **how effectively** those capabilities must operate within the business environment. During the analysis phase, these quality attributes were treated as business requirements for solution quality rather than purely technical considerations, as they directly influence operational efficiency, user confidence, system reliability and long-term maintainability.

The identified Non-Functional Requirements were derived through analysis of stakeholder expectations, operational constraints, anticipated system usage, organisational policies and maintainability objectives. These requirements subsequently influenced architectural decisions, database design, validation strategies, exception handling mechanisms and implementation standards throughout the development lifecycle.

Rather than being implemented as isolated technical controls, each quality attribute was considered during solution design to ensure that operational performance, usability, security and maintainability remained aligned with the defined business objectives.

---

### NFR-01 — Usability

Usability was identified as a critical quality attribute due to the operational nature of the application. Pharmacy staff perform repetitive administrative activities throughout the working day, requiring an interface that supports rapid task completion while minimising cognitive effort and operational errors.

From a Business Analysis perspective, improving usability contributes directly to increased operational productivity, reduced training effort and greater user adoption.

The solution therefore prioritises:

- Logical navigation between business functions.
- Consistent interface behaviour across modules.
- Clearly labelled forms and controls.
- Contextual validation messages.
- Simple data entry workflows.
- Intuitive search and filtering capabilities.
- Clear confirmation and feedback mechanisms for business-critical operations.

These usability considerations ensure that business processes remain efficient without introducing unnecessary interaction complexity.

---

### NFR-02 — Performance

Performance requirements were established to ensure that routine operational activities could be completed without introducing delays that negatively affect customer service or administrative efficiency.

The system was designed to satisfy the response time objectives defined within the Software Requirements Specification, ensuring that normal user interactions complete within acceptable operational thresholds. :contentReference[oaicite:0]{index=0}

Performance considerations influenced several implementation decisions, including:

- Efficient SQLite query execution.
- Structured data retrieval mechanisms.
- Controlled form initialisation.
- Optimised dashboard calculations.
- Search and filtering logic.
- Lightweight desktop deployment architecture.

Maintaining acceptable response times supports uninterrupted business operations while improving overall user satisfaction.

---

### NFR-03 — Reliability

Reliability ensures that the application consistently performs expected business operations while maintaining accurate business information throughout normal system usage.

Operational reliability was considered particularly important because pharmacy activities involve inventory information, customer records, prescriptions and transactional data where inconsistencies could directly affect business operations.

To support reliability, the solution incorporates:

- Structured validation prior to transaction processing.
- Controlled database operations.
- Exception handling mechanisms.
- Consistent business workflow execution.
- Transaction confirmation before critical updates.
- Controlled inventory adjustments following successful order processing.

These controls reduce the likelihood of inconsistent operational behaviour while maintaining confidence in business information.

---

### NFR-04 — Availability

As a desktop-based business application, SmartMed was designed to remain available whenever the operational environment is active.

The solution intentionally avoids unnecessary external service dependencies, allowing business operations to continue without reliance on continuous Internet connectivity. This design decision aligns with the deployment assumptions documented within the Software Requirements Specification and supports uninterrupted pharmacy operations. :contentReference[oaicite:1]{index=1}

---

### NFR-05 — Security

Security requirements were analysed from the perspective of protecting organisational information rather than simply implementing authentication controls.

The solution incorporates multiple security measures intended to safeguard customer information and business data throughout operational workflows.

These include:

- Role-based authentication.
- Secure credential verification.
- Password masking during authentication.
- Controlled access to administrative functionality.
- Session management.
- Input validation.
- Controlled execution of business-critical operations.

Although the project operates as a desktop application, these controls establish an appropriate baseline for protecting sensitive business information while reducing unauthorised access.

---

### NFR-06 — Maintainability

Maintainability was treated as a strategic quality objective throughout the project to ensure that future enhancements could be implemented without introducing unnecessary technical complexity.

Rather than organising the application around individual forms, the solution adopts a structured object-oriented architecture that separates business logic, data models, helper components and presentation responsibilities into clearly defined layers.

This approach improves:

- Code readability.
- Requirement traceability.
- Component reusability.
- Defect isolation.
- Future feature enhancement.
- Corrective maintenance activities.

The modular architecture also supports incremental system evolution without requiring extensive modification to existing business functionality.

---

### NFR-07 — Scalability

Although the current implementation targets a single desktop deployment, scalability considerations were incorporated during analysis to support future organisational growth.

Business processes were designed to accommodate increasing volumes of:

- Medicine records.
- Customer records.
- Orders.
- Prescriptions.
- Transaction history.
- Operational reports.

The object-oriented architecture, normalised database structure and modular implementation provide an extensible foundation capable of supporting future functional expansion while maintaining solution consistency.

---

### NFR-08 — Portability

Portability requirements were defined to ensure that the application can be deployed consistently across supported Windows environments without requiring significant platform-specific modification.

Selecting the .NET Framework and Windows Forms platform aligns with the operational constraints established during project planning while supporting reliable desktop deployment within the intended business environment.

---

### NFR-09 — Data Integrity

Maintaining accurate and consistent business information was identified as one of the most critical quality objectives within the solution.

Data integrity requirements influenced numerous implementation decisions, including:

- Field validation.
- Mandatory data constraints.
- Duplicate record prevention.
- Unique entity identification.
- Inventory consistency checks.
- Controlled database updates.
- Business rule enforcement.

These mechanisms ensure that business information remains accurate throughout operational processing while reducing the likelihood of inconsistent or invalid records.

---

### NFR-10 — Exception Handling

Operational continuity depends upon the application's ability to manage unexpected conditions without disrupting business activities.

Rather than allowing runtime failures to terminate business processes, the solution incorporates structured exception handling to detect, manage and communicate operational errors while preserving application stability.

This approach contributes towards improved reliability, maintainability and user confidence.

---

### NFR-11 — Validation

Input validation was implemented as an essential business control rather than merely a user interface feature.

Validation activities occur before business transactions are processed to ensure that operational data satisfies documented business rules and organisational policies.

Validation includes:

- Mandatory field verification.
- Numeric validation.
- Stock availability validation.
- Duplicate record prevention.
- Authentication validation.
- Prescription verification.
- Business rule compliance.

By validating business information before processing, the solution protects operational integrity while reducing downstream processing errors.

---

### NFR-12 — Accessibility

Accessibility requirements focused on ensuring that users can complete operational activities efficiently regardless of technical expertise.

The interface incorporates:

- Consistent navigation structures.
- Clear field labels.
- Readable typography.
- Informative validation messages.
- Logical workflow progression.
- Immediate operational feedback.

These design considerations improve overall usability while supporting efficient execution of daily pharmacy activities.

---

### Quality Attribute Traceability

Throughout solution development, Non-Functional Requirements were continuously validated alongside Functional Requirements to ensure that quality objectives remained embedded within both the architecture and implementation.

Each quality attribute informed multiple technical decisions spanning interface design, object-oriented architecture, validation mechanisms, database interactions and exception handling.

Maintaining this relationship between quality requirements and implementation strengthened solution consistency while ensuring that operational performance, security, maintainability and reliability remained aligned with documented stakeholder expectations.

---

# Technical Requirements

Technical Requirements define the technological foundation necessary to realise the documented business requirements while remaining consistent with the project's operational constraints, architectural objectives and implementation strategy.

Rather than selecting technologies based solely on familiarity, each technical decision was evaluated against its ability to support maintainability, solution stability, implementation feasibility and long-term extensibility.

The resulting technology stack represents a balanced alignment between business requirements, software engineering principles and the practical constraints defined within the Software Requirements Specification.

---

## Technical Architecture Requirements

The solution architecture was established after the completion of the requirements analysis to ensure that the implemented system remained aligned with documented business objectives rather than technology-driven decisions. Every architectural decision was evaluated against its contribution to maintainability, scalability, traceability, modularity and long-term solution sustainability.

The architecture was intentionally designed to separate business concerns into clearly defined functional components, reducing coupling between presentation, business processing and data management responsibilities. This separation improves maintainability, simplifies future enhancements and enables individual system components to evolve without introducing unnecessary impact across unrelated business functions.

The implemented architecture comprises the following logical layers:

- **Presentation Layer** – Provides Windows Forms interfaces through which administrators and customers interact with business services.
- **Business Logic Layer** – Encapsulates operational workflows, business validations and decision-making processes while ensuring compliance with documented business rules.
- **Data Access Layer** – Manages interactions with the SQLite database through structured data operations while preserving consistency and integrity.
- **Domain Model Layer** – Represents core business entities including medicines, customers, prescriptions, orders and users, ensuring that business concepts remain consistent across the application.

This layered architecture establishes a clear separation of responsibilities, improves maintainability, supports component reusability and strengthens traceability between business requirements, implementation and future enhancement activities.

---

## Hardware Requirements

Hardware Requirements were established to ensure that the proposed solution could operate efficiently within the intended organisational environment without requiring specialised infrastructure or high-end computing resources.

Considering the operational profile of a community pharmacy, the solution was designed to function effectively on standard desktop workstations typically available within small and medium-sized healthcare businesses.

The minimum hardware environment includes:

| Component | Requirement |
|-----------|-------------|
| Processor | Intel Core i3 (or equivalent) or higher |
| Memory | Minimum 4 GB RAM (8 GB recommended) |
| Storage | Minimum 500 MB available disk space |
| Display | 1366 × 768 resolution or higher |
| Input Devices | Keyboard and Mouse |

The desktop deployment model reduces infrastructure complexity while enabling efficient day-to-day operation without dependence on dedicated application servers or cloud-hosted environments.

---

## Software Requirements

Software Requirements define the execution environment necessary for successful deployment, operation and maintenance of the SmartMed Pharmacy Management System.

The selected software environment was aligned with both the documented project constraints and the implementation strategy established during solution design.

The operational environment includes:

| Software Component | Purpose |
|--------------------|---------|
| Microsoft Windows | Primary operating environment |
| .NET Framework | Runtime platform for application execution |
| SQLite | Local relational database management system |
| Windows Forms | Desktop presentation framework |

This software environment provides a stable and lightweight deployment model while supporting the application's functional scope and operational requirements.

The use of a local relational database also contributes to simplified deployment, reduced infrastructure costs and improved portability within the intended organisational context.

---

## Development Environment & Technology Stack

Technology selection was driven by business and architectural considerations rather than individual implementation preferences. Each technology was evaluated according to its ability to satisfy documented business requirements, support maintainability and facilitate structured software development.

The selected development environment comprised:

| Technology | Business Rationale |
|------------|--------------------|
| **C#** | Supports object-oriented design principles, maintainable code structure and robust desktop application development. |
| **.NET Framework** | Provides a mature and stable runtime environment suitable for Windows desktop solutions. |
| **Windows Forms** | Enables rapid development of structured business interfaces while supporting efficient user interaction. |
| **SQLite** | Delivers lightweight relational data management suitable for standalone desktop deployments without requiring dedicated database infrastructure. |
| **Visual Studio** | Provides an integrated development environment supporting implementation, debugging, testing and solution maintenance. |
| **Git & GitHub** | Supports structured version control, configuration management and collaborative software development practices. |

The selected technology stack satisfies the constraints documented within the Software Requirements Specification while providing an appropriate balance between implementation simplicity, architectural quality and future maintainability. :contentReference[oaicite:0]{index=0}

---

