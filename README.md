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

## Derived Requirements

Although the Software Requirements Specification established the project's explicit business and functional requirements, the analysis process identified several additional requirements that were not directly articulated by stakeholders but were essential to delivering a complete, reliable and operationally viable solution. These derived requirements emerged through detailed examination of business workflows, entity relationships, process dependencies, exception scenarios and implementation feasibility. Their identification reduced ambiguity, strengthened solution completeness and ensured alignment between business objectives and technical implementation. The SRS itself distinguishes these as implicit requirements necessary for correct system behaviour.

Unlike stakeholder-driven requirements, derived requirements were established through analytical reasoning by evaluating how individual business capabilities interacted across the complete operational lifecycle. These requirements ensured that business processes remained consistent under normal, exceptional and boundary conditions while supporting data integrity, operational continuity and regulatory compliance.

### Principal Derived Requirements

#### DR-01 — Unique Business Entity Identification
Every core business entity—including Medicines, Customers, Orders and Prescriptions—requires a system-generated unique identifier to maintain entity integrity, eliminate duplication and support reliable referencing across relational database structures.

#### DR-02 — Automated Inventory Synchronisation
Successful order completion automatically updates medicine inventory levels to ensure that stock availability accurately reflects operational transactions and prevents discrepancies between physical inventory and recorded inventory.

#### DR-03 — Stock Availability Verification
Before confirming customer purchases, inventory availability is validated to ensure sufficient stock exists to fulfil the requested quantity. This prevents overselling while preserving inventory accuracy.

#### DR-04 — Prescription Validation Workflow
Medicines classified as prescription-controlled require successful verification of an uploaded prescription before order confirmation. This additional validation workflow supports regulatory compliance while ensuring controlled medicines cannot bypass approval procedures.

#### DR-05 — Dynamic Business Calculations
Operational values including order totals, promotional discounts, dashboard statistics and inventory indicators are calculated dynamically from transactional data rather than being manually maintained, ensuring that management information remains accurate and current throughout daily operations.

#### DR-06 — Session Continuity
Authenticated users maintain an active session throughout their interaction with the application until an explicit logout occurs. This provides a consistent user experience while preserving controlled access to secured business functions.

#### DR-07 — Operational Data Validation
Input validation is applied before business transactions are processed to ensure completeness, accuracy and compliance with established business rules. Invalid information is rejected prior to database operations, reducing processing errors and protecting data quality.

#### DR-08 — Confirmation-Based Critical Operations
Business operations capable of modifying organisational data—including record deletion, order confirmation and transaction completion—require explicit user confirmation before execution. This reduces accidental modifications while improving operational accountability.

#### DR-09 — Exception Handling
Database failures, invalid transactions and unexpected runtime events are intercepted through structured exception handling mechanisms that maintain application stability while providing meaningful feedback to users without exposing technical implementation details.

#### DR-10 — Real-Time Operational Reporting
Management reports are generated directly from live operational data rather than static report repositories, ensuring that analytical outputs accurately represent current organisational performance and support informed managerial decision-making.

### Analytical Value of Derived Requirements
From a Business Analysis perspective, identifying derived requirements significantly reduced implementation uncertainty by addressing operational behaviours that stakeholders often consider implicit rather than explicitly documenting. While these requirements were not directly requested during initial requirement definition, they became essential for maintaining consistency between business expectations, process execution, database behaviour and application functionality.

Furthermore, these analytical outputs established a stronger foundation for subsequent architectural design, database modelling, object-oriented implementation and system testing by ensuring that every operational scenario could be traced back to a clearly understood business objective. This approach reduced the likelihood of functional gaps, strengthened solution completeness and improved the long-term maintainability of the SmartMed Pharmacy Management System.

---

## Assumptions

Every software initiative operates within a set of assumptions that define the expected business environment during solution development. Documenting these assumptions was essential for establishing a realistic analytical baseline, reducing uncertainty during requirements engineering and ensuring that subsequent architectural and implementation decisions remained aligned with the agreed project scope. The assumptions documented in the SRS define the intended operating environment for the application.

Rather than representing confirmed business facts, the following assumptions defined conditions that were considered valid throughout the analysis, design and development lifecycle unless future stakeholder decisions required revision.

### AS-01 — Single-Branch Operational Context
The solution assumes operation within a single pharmacy environment where inventory, customers, prescriptions and transactions are managed from a central operational database. Multi-branch inventory synchronisation and distributed operations were considered outside the approved project scope.

### AS-02 — Desktop-Based Operational Environment
The application assumes execution within a Windows desktop environment using the Microsoft .NET Framework. Business processes are therefore optimised for desktop interaction rather than web or mobile deployment.

### AS-03 — Local Database Deployment
Operational data is assumed to be maintained within a locally hosted SQLite database, providing sufficient performance, reliability and simplified deployment for the defined business environment without introducing external database dependencies.

### AS-04 — Role-Based Operational Responsibilities
Administrative users are assumed to possess appropriate authority for managing medicines, customers, reports and operational activities, while customer users interact exclusively with consumer-facing functionality such as medicine searching, profile management and order placement.

### AS-05 — Availability of Accurate Operational Data
The effectiveness of inventory management, reporting and dashboard analytics assumes that administrative users maintain accurate medicine records, stock quantities, pricing information and prescription classifications throughout normal business operations.

### AS-06 — Stable Business Policies
Business rules governing prescription handling, inventory management, pricing and order processing are assumed to remain stable throughout development. Significant policy changes would require controlled requirement revisions and corresponding updates to design artefacts.

### AS-07 — Organisational Readiness
The organisation is assumed to possess the necessary technical infrastructure, computing resources and personnel required to operate and maintain the application within its intended business environment.

### Business Analysis Perspective
Clearly documenting analytical assumptions established defined boundaries for solution planning while reducing uncertainty during requirements interpretation. Recording these assumptions also provided a structured mechanism for identifying future project risks should business conditions, organisational policies or stakeholder expectations evolve beyond the agreed analytical baseline.

---

## Constraints

Project constraints establish the boundaries within which a software solution must be analysed, designed, implemented and validated. Unlike assumptions, which represent expected operating conditions, constraints define mandatory limitations that directly influence architectural decisions, technology selection, implementation strategy and overall solution scope. The SmartMed SRS explicitly constrains the development language, application type, development environment and object-oriented implementation approach.

Throughout the SmartMed Pharmacy Management System, the following constraints governed both Business Analysis activities and technical solution development.

### CN-01 — Technology Constraints
The application was required to be developed using C#, Windows Forms and the .NET Framework, establishing the technology baseline for the entire Software Development Life Cycle. These constraints directly influenced architectural decisions, user interface design and implementation strategy.

### CN-02 — Database Constraint
Persistent business data was required to be maintained using a local SQLite database. Consequently, database modelling, entity relationships, integrity constraints and transaction management were designed specifically to support SQLite capabilities while preserving long-term maintainability.

### CN-03 — Architectural Constraint
The solution architecture was required to support Object-Oriented Software Engineering principles including abstraction, encapsulation, inheritance and modularity. This requirement influenced domain modelling, class responsibilities, component separation and overall application maintainability.

### CN-04 — Scope Constraint
The approved project scope focused on core pharmacy operations, including authentication, medicine management, customer management, prescription handling, reporting, inventory monitoring and order processing. Broader enterprise capabilities such as supplier integration, online payment gateways, cloud synchronisation and multi-branch management were intentionally excluded to preserve project feasibility.

### CN-05 — Resource Constraint
Development activities were completed within predefined academic timelines while maintaining alignment between business analysis deliverables, architectural artefacts, database design, implementation and system testing. This required disciplined prioritisation throughout the Software Development Life Cycle.

### CN-06 — Compliance Constraint
Business processes were required to enforce organisational policies relating to prescription-controlled medicines, inventory validation, unique entity identification and controlled order processing. These mandatory constraints ensured that implemented functionality remained consistent with documented business rules and operational expectations.

### Business Analysis Perspective
Identifying project constraints during the analysis phase enabled realistic scope definition, informed solution evaluation and prevented requirements that could not be delivered within the agreed technological and organisational boundaries. More importantly, documenting these limitations ensured that every subsequent design decision—including UML modelling, database architecture, object-oriented implementation and testing—remained aligned with both business objectives and project feasibility.


---

# Requirements Verification & Validation

Requirements Verification and Validation (V&V) formed a continuous governance activity throughout the SmartMed project rather than a single quality assurance checkpoint performed at the end of development. From a Business Analysis perspective, the objective was to ensure that every documented requirement was technically feasible, internally consistent, aligned with stakeholder expectations, and capable of delivering measurable business value once implemented.

Verification focused on assessing the quality of the documented requirements before implementation commenced, while validation confirmed that the completed solution satisfied the intended business objectives throughout implementation and testing. Maintaining this distinction reduced implementation ambiguity and ensured that business expectations remained aligned with the delivered solution.

---

## Requirements Verification

Verification activities concentrated on evaluating the quality and completeness of the requirements baseline before progressing into architecture, database modelling and software development.

Each requirement was reviewed against recognised requirement quality characteristics to ensure that it was suitable for implementation and capable of supporting subsequent design activities.

The verification process evaluated the following quality attributes:

| Verification Attribute | Verification Objective |
|------------------------|------------------------|
| **Completeness** | Confirmed that all identified business processes and stakeholder needs were adequately documented. |
| **Consistency** | Ensured that individual requirements did not contradict business rules, UML models or related requirements. |
| **Correctness** | Verified that each requirement accurately represented the intended business behaviour. |
| **Clarity** | Removed ambiguity by defining requirements using measurable and implementation-ready statements. |
| **Feasibility** | Assessed technical and operational practicality within the agreed project scope and technology stack. |
| **Testability** | Confirmed that every requirement could be objectively verified through testing activities. |
| **Traceability** | Established relationships between requirements and downstream analytical and implementation artefacts. |

Applying these verification activities before implementation significantly reduced requirement volatility, improved analytical consistency and provided a stable foundation for architectural design and object-oriented development.

---

## Requirements Validation

Validation activities focused on confirming that the implemented application fulfilled the operational objectives established during stakeholder analysis and requirements engineering.

Rather than validating isolated software features, validation considered the complete business workflow to ensure that implemented functionality reflected the intended operational behaviour of the pharmacy management process.

Validation confirmed that:

- Business objectives were successfully translated into operational system capabilities.
- Functional requirements were implemented in accordance with the approved requirements baseline.
- Business rules were consistently enforced throughout transactional workflows.
- Customer-facing and administrative processes aligned with documented operational scenarios.
- Database behaviour maintained the integrity of business information across related entities.
- User interface workflows supported efficient execution of day-to-day pharmacy operations.
- Reporting and dashboard functions provided meaningful operational insight for business decision-making.
- Exception handling and validation mechanisms protected business processes from invalid operational states.

Validation evidence was obtained through functional testing, business rule verification, database validation, workflow execution, user interface testing and end-to-end scenario testing. This iterative validation approach ensured that the delivered solution remained aligned with documented business needs while maintaining consistency across analytical, architectural and implementation artefacts.

---

# Requirements Traceability

Maintaining end-to-end requirements traceability was a fundamental Business Analysis practice adopted throughout the SmartMed project. Rather than treating requirements as independent specification statements, each requirement was systematically connected to the subsequent analytical, design, implementation and testing artefacts generated during the Software Development Life Cycle.

This structured traceability model ensured that every implemented capability could be justified against a documented business objective while enabling efficient impact analysis, validation and future system enhancement.

---

## Traceability Strategy

The project established a progressive relationship between business needs and implementation outcomes through the following traceability chain:

```text
Business Objectives
        │
        ▼
Stakeholder Needs
        │
        ▼
Business Requirements
        │
        ▼
Functional & Non-Functional Requirements
        │
        ▼
Business Rules
        │
        ▼
Use Cases
        │
        ▼
Business Process Models
        │
        ▼
UML Design Artefacts
(System Architecture, ERD,
Class, Sequence & Activity Diagrams)
        │
        ▼
Database Design
        │
        ▼
Object-Oriented Implementation
        │
        ▼
Testing & Solution Validation
```

---

## Traceability Across the SDLC

Requirements traceability extended beyond documentation by providing continuity throughout every phase of solution delivery.

During analysis, traceability ensured that stakeholder expectations were translated into measurable business and functional requirements. During solution design, those requirements informed the development of UML models, database structures and architectural decisions. Throughout implementation, individual software components and business objects were developed in accordance with the approved analytical baseline. Finally, testing activities validated that implemented functionality continued to satisfy the originating business objectives.

This disciplined approach ensured that changes could be evaluated with minimal ambiguity, design decisions remained business-driven, and implementation activities consistently reflected the approved requirements baseline.

---

## Business Value of Traceability

Maintaining comprehensive traceability delivered several strategic benefits to the project:

- Preserved alignment between stakeholder expectations and implemented functionality.
- Reduced the risk of omitted, duplicated or conflicting requirements.
- Improved impact assessment when introducing design or implementation changes.
- Simplified verification and validation throughout the development lifecycle.
- Strengthened consistency between analytical documentation, UML models, database design and source code.
- Supported long-term maintainability by providing a clear rationale for implemented business capabilities.
- Increased confidence that every delivered feature contributed directly to an identified organisational objective.

From a Business Analysis perspective, traceability acted as the governance mechanism that connected business strategy with technical execution, ensuring that the completed SmartMed Pharmacy Management System represented a business-aligned software solution rather than a collection of independent application features.


---

# Business Rules

Business Rules represent the operational policies that govern how the SmartMed Pharmacy Management System behaves within the pharmacy business environment. While requirements describe the capabilities that the solution must provide, business rules define the conditions under which those capabilities are permitted to operate.

Throughout the analysis phase, business rules were treated as organisational policies rather than technical validations. They established the operational boundaries within which business processes could execute, ensuring that every transaction remained consistent with pharmacy procedures, inventory controls and customer service expectations.

These rules became the governing layer between Requirements Engineering and Solution Design, influencing business workflows, UML models, database constraints, object-oriented implementation and validation activities. Rather than existing as isolated statements within the Software Requirements Specification, each business rule was translated into executable system behaviour that could be consistently enforced throughout the application lifecycle.

---

## Business Rule Identification

Business rules were derived through detailed analysis of stakeholder objectives, operational workflows, regulatory considerations, inventory management practices and transaction dependencies documented within the Software Requirements Specification.

The analysis identified several categories of operational rules required to support reliable pharmacy operations:

| Business Rule Category | Business Purpose |
|------------------------|------------------|
| Authentication Rules | Protect administrative functions through controlled user access. |
| Customer Governance | Ensure only registered customers can perform purchasing activities. |
| Inventory Control | Prevent invalid stock transactions and maintain inventory accuracy. |
| Prescription Compliance | Enforce mandatory prescription validation for regulated medicines. |
| Order Processing | Standardise the complete order lifecycle from creation to fulfilment. |
| Pricing & Promotions | Maintain consistent pricing while supporting promotional discounts. |
| Reporting Rules | Ensure reports reflect current operational data for decision-making. |
| Data Governance | Protect business information through validation and integrity controls. |

This structured classification ensured that business policies remained traceable across analytical documentation, database design and implemented business logic.

---

## Business Rule Enforcement

Business rules were not documented solely for reference; they were embedded directly within the operational behaviour of the application.

Throughout implementation, each business rule influenced one or more solution components, including user interface validation, business logic modules, database operations and transaction processing.

Examples include:

- Authentication controls restricting administrative functionality to authorised users.
- Validation preventing duplicate customer accounts and invalid business records.
- Inventory controls preventing medicine stock from falling below permissible levels.
- Automatic verification of prescription requirements before completing regulated medicine purchases.
- Order lifecycle management enforcing approved status transitions.
- Automated inventory adjustments following successful order confirmation.
- Dynamic dashboard calculations reflecting current operational data.
- Report generation using live transactional information rather than manually maintained summaries.

Embedding business rules throughout the solution ensured that operational policies remained consistently enforced regardless of the user workflow being executed.

---

## Business Value of Business Rules

From a Business Analysis perspective, business rules provide considerably more value than simple system validations.

Within SmartMed, they establish consistency across operational processes, reduce ambiguity during implementation, improve data quality and ensure that organisational policies are reflected within everyday business activities.

The adoption of clearly defined business rules delivered several organisational benefits:

- Standardised operational behaviour across all business processes.
- Reduced opportunities for inconsistent or invalid transactions.
- Improved inventory accuracy through controlled stock management.
- Strengthened compliance for prescription-controlled medicines.
- Increased confidence in operational reporting and dashboard analytics.
- Improved maintainability by separating business policy from user interface behaviour.
- Greater consistency between documented requirements, implemented functionality and expected business outcomes.

This governance layer ultimately ensured that business processes remained predictable, repeatable and aligned with organisational objectives throughout the solution lifecycle.

---

# Business Process Analysis

Business Process Analysis (BPA) was undertaken to understand how operational activities should flow across the pharmacy before defining the solution architecture and software components.

Rather than modelling individual application screens, the analysis focused on understanding business events, process dependencies, stakeholder interactions, decision points, information flows and operational outcomes. This ensured that solution design reflected actual business operations instead of isolated technical functionality.

The resulting process models became the foundation for the Use Case Diagram, Activity Diagrams, Sequence Diagrams, Entity Relationship Diagram, Class Diagram and subsequent object-oriented implementation.

---

## Business Process Modelling Approach

The project adopted a process-driven analysis approach in which every major operational workflow was decomposed into logical business activities before implementation commenced.

Each business process was analysed using the following perspectives:

- Process trigger.
- Participating stakeholders.
- Business activities.
- Decision points.
- Business rules.
- Data interactions.
- Expected business outcome.

This structured analysis reduced process ambiguity while ensuring that every implemented workflow supported a clearly defined operational objective.

---

## Core Business Processes

Analysis identified several business-critical operational processes that collectively define the day-to-day activities performed within the pharmacy environment.

The primary business processes include:

| Business Process | Operational Objective |
|------------------|-----------------------|
| User Authentication | Establish secure access to authorised system functions. |
| Medicine Management | Maintain accurate inventory throughout the medicine lifecycle. |
| Customer Management | Maintain complete and reliable customer information. |
| Medicine Discovery | Support efficient medicine search and product selection. |
| Prescription Processing | Validate prescription-controlled medicines prior to fulfilment. |
| Order Processing | Manage customer purchases through a controlled transaction workflow. |
| Inventory Monitoring | Continuously maintain stock availability and expiry visibility. |
| Reporting & Analytics | Support operational monitoring and management decision-making. |

Each process was subsequently modelled using UML behavioural diagrams to ensure analytical consistency before implementation.

---

## Process Optimisation Considerations

Business Process Analysis also identified opportunities to improve operational efficiency by reducing unnecessary manual intervention throughout routine pharmacy activities.

Several optimisation opportunities were incorporated into the solution, including:

- Automated inventory updates following successful transactions.
- Dynamic dashboard KPI calculations based on operational data.
- Integrated prescription validation within the purchasing workflow.
- Streamlined medicine discovery using search, filtering and sorting mechanisms.
- Automated report generation from transactional information.
- Centralised customer information management.
- Controlled order lifecycle progression through predefined operational states.

These improvements reduced repetitive administrative effort while improving operational consistency and information accuracy.

---

## Relationship Between Business Processes and Solution Design

Business Process Analysis directly informed every subsequent design activity within the project.

The documented workflows provided the behavioural foundation for:

- Use Case modelling.
- Activity Diagrams.
- Sequence Diagrams.
- Entity Relationship modelling.
- Class design.
- Database structure.
- Business object interactions.
- Object-oriented implementation.

Maintaining this analytical continuity ensured that technical design decisions remained driven by documented business processes rather than implementation convenience.

Consequently, every significant software component implemented within SmartMed can be traced back to an analysed operational process, preserving alignment between organisational objectives, analytical artefacts and delivered functionality.

---

# Requirements Engineering Summary

Requirements Engineering established the analytical foundation upon which the entire SmartMed Pharmacy Management System was designed, implemented and validated.

Rather than limiting the discipline to documenting software functionality, the project adopted a structured Business Analysis approach that progressively transformed organisational objectives into implementable solution components through stakeholder analysis, requirements elicitation, business process analysis, business rule definition and solution modelling.

The resulting requirements baseline informed architectural decisions, database design, UML artefacts, object-oriented implementation and testing activities while maintaining end-to-end traceability throughout the Software Development Life Cycle.

By preserving alignment between business objectives, stakeholder expectations, operational processes, analytical models and implemented functionality, the completed solution represents more than a technically functional desktop application. It demonstrates a business-driven software solution developed through disciplined Requirements Engineering, structured Business Analysis and evidence-based solution design principles.

This analytical approach ensured that every implemented capability delivered measurable business value while supporting long-term maintainability, scalability and operational consistency—reflecting the practices expected within professional Business Analysis and enterprise software delivery environments.

---

# Solution Architecture

Requirements Engineering established **what** the SmartMed Pharmacy Management System needed to achieve from a business perspective. The next stage focused on determining **how** those business capabilities should be realised through a solution architecture capable of supporting maintainability, consistency and long-term operational sustainability.

Rather than selecting a technology stack and designing application components independently, the architecture was derived directly from the approved requirements baseline. Every architectural responsibility, system module and data interaction was evaluated against documented business processes, stakeholder expectations and operational rules to ensure that the implemented solution remained aligned with the organisational objectives established during Business Analysis.

The resulting architecture defines a structured separation of responsibilities across the application while maintaining complete traceability between business requirements, application services, database operations and implemented functionality. This separation reduces unnecessary coupling, improves maintainability, simplifies future enhancement activities and enables individual business capabilities to evolve with minimal impact on unrelated components.

The architectural model also provides the foundation for all subsequent design artefacts presented throughout this section, including behavioural models, structural models, database design and object-oriented implementation.

---

## Layered Solution Architecture

> **Architecture Diagram Placeholder**

<p align="center">

**[Insert SmartMed System Architecture Diagram Here]**

</p>

*Figure — SmartMed Pharmacy Management System Layered Solution Architecture.*

### Architectural Analysis

The SmartMed Pharmacy Management System adopts a layered architectural model that organises the solution into five distinct architectural responsibilities: **Actors**, **Presentation Layer**, **Business Logic Layer**, **Data Access Layer** and **Database Layer**. Rather than functioning as independent technical components, these layers collectively establish a controlled execution pathway through which every business transaction is validated, processed and persisted.

User interaction begins within the Windows Forms Presentation Layer, where administrators and customers execute business operations through dedicated interfaces aligned with their operational responsibilities. The presentation layer intentionally remains lightweight, limiting its responsibility to interaction management while delegating all business decision-making to specialised service modules. This separation ensures that user interface changes do not introduce unintended impacts on core business behaviour.

The Business Logic Layer represents the architectural core of the solution. Each module corresponds directly to a documented business capability—including authentication, medicine management, customer administration, prescription processing, order management, reporting and dashboard analytics—thereby preserving direct traceability between approved business requirements and implemented application services. Business rules are enforced centrally within this layer, ensuring consistent operational behaviour regardless of the originating user interface.

The Data Access Layer acts as an abstraction boundary between business processing and persistent storage. Database communication is encapsulated within a dedicated Database Manager responsible for connection management, query execution and transaction handling. By isolating persistence concerns from business processing, the architecture improves maintainability, reduces implementation dependencies and enables future database changes with minimal impact on business modules.

Persistent organisational information is maintained within a normalised SQLite relational database containing the application's principal business entities, including Administrators, Customers, Medicines, Orders, Order Items and Prescriptions. The relational structure supports referential integrity, efficient transaction processing and consistent data governance across the complete operational lifecycle.

From a Business Analysis perspective, the architecture demonstrates strong alignment between business capabilities and technical implementation. Every architectural component exists to realise a defined organisational requirement rather than introducing unnecessary technical complexity. This alignment preserves end-to-end traceability across Requirements Engineering, Solution Design, Object-Oriented Development and Verification activities, ensuring that the delivered solution remains business-driven throughout the Software Development Life Cycle.

---
